using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PathFinder
{
    public partial class PathFinderForm : Form
    {
        internal JObject theJSON = new JObject();
        private string _website;

        internal PathFinderForm()
        {
            InitializeComponent();

            _website = "https://github.com/generalwrex/DBM-WebAPI-Parser-PathFinder";
        }

        #region Event Handlers

        #region Disabled Control Events

        private void bGoPath_Click(object sender, EventArgs e)
        {
        }

        private void bBrowseForFile_Click(object sender, EventArgs e)
        {
        }

        private void rtbInputJson_Enter(object sender, EventArgs e)
        {
        }

        private void rtbInputJson_TextChanged(object sender, EventArgs e)
        {
            //ParseJSONFromInput();
        }

        private void tvOutputViewer_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        #endregion Disabled Control Events

        #region File Menu Events

        private void toolStripButton_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton_Help_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(_website);
        }

        private void toolStripButton1_Donate_Click(object sender, EventArgs e)
        {
            string donateURL = "https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=generalwrex%40gmail%2ecom" +
                "&lc=US&item_name=Generalwrex%27s%20Programs&no_note=0&currency_code=USD&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHostedGuest";
            System.Diagnostics.Process.Start(donateURL);
        }

        private void toolStripButton_About_Click(object sender, EventArgs e)
        {
            string text = @"
             This program was created by General Wrex.

             It's designed to help you get the Path variable
             in the WebAPI Parsing mod/action for Discord Bot Maker

             Thanks for using this program! If you have any issues please
             Report them to PathFinders GitGub page! You can find it by
             Selecting the Help option on the File menu.
             ";

            DialogResult result2 = MessageBox.Show(text,
                "About PathFinder",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
        }

        #endregion File Menu Events

        private void bGoURL_Click(object sender, EventArgs e)
        {
            try
            {
                var url = tbUrl.Text;

                bool result = Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

                if (result)
                {
                    ParseJSONFromURL(url);

                    rtbInputJson.Text = theJSON.ToString();
                }
                else
                    MessageBox.Show("The URL Is Not Valid! " + url, "JSON Object ERROR");
            }
            catch (Exception)
            {
            }
        }

        private void tbUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToInt16(Keys.Enter))
            {
                e.Handled = true;

                bGoURL_Click(sender, e);
            }
        }

        private void rtbInputJson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToInt16(Keys.Enter))
            {
                ParseJSONFromInput(rtbInputJson.Text);
            }
        }

        private void tvOutputViewer_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string outputPath = null;

            // if the double clicked node has no children, aka.. the value
            if (e.Node.Nodes.Count != 0)
                return;

            IList<TreeNode> ancestorList = TreeHelpers.GetAncestors(e.Node, x => x.Parent).ToList();

            foreach (TreeNode row in ancestorList.Reverse())
            {
                if (string.IsNullOrEmpty(row.Text))
                    break;

                outputPath += "." + row.Text;
            }

            var path = outputPath?.Replace(".body", "").Replace(".PathFinder_JSON_Object", "");

            if (path.All(char.IsWhiteSpace))
                return;

            rtbSelectedPaths.AppendText(path.TrimStart('.') + "\r\n");
        }

        #endregion Event Handlers

        #region Methods

        #region Disabled Methods

        public void ParseJSONFromFile(string path)
        {
            if (!File.Exists(path))
                MessageBox.Show("That File Doesn't Exist.", "ParseJSONFromFile ERROR");

            try
            {
                using (StreamReader r = new StreamReader(path))
                {
                    string json = r.ReadToEnd();

                    if (!CheckValidJSON(json))
                    {
                        MessageBox.Show("The JSON Is Not Valid!", "JSON Object ERROR");
                        return;
                    }

                    theJSON = JObject.Parse(json);

                    AddJSONToTree(theJSON);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ParseJSONFromFile ERROR");
            }
        }

        #endregion Disabled Methods

        private void ParseJSONFromURL(string URL)
        {
            try
            {
                using (var webClient = new System.Net.WebClient())
                {
                    webClient.Headers.Add("User-Agent: Other");

                    var json = webClient.DownloadString(URL);

                    if (!CheckValidJSON(json))
                    {
                        MessageBox.Show("The JSON Is Not Valid!", "JSON Object ERROR");
                        return;
                    }

                    theJSON = JObject.Parse(json);

                    AddJSONToTree(theJSON);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ParseJSONFromURL ERROR");
            }
        }

        private void ParseJSONFromInput(string inputText)
        {
            try
            {
                if (!CheckValidJSON(inputText))
                {
                    MessageBox.Show("The JSON Is Not Valid!", "JSON Object ERROR");
                    return;
                }

                theJSON = JObject.Parse(inputText);

                AddJSONToTree(theJSON);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ParseJSONFromInput ERROR");
            }
        }

        private bool CheckValidJSON(string jsonString)
        {
            try
            {
                var json = JObject.Parse(jsonString);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private void AddJSONToTree(JObject obj)
        {
            try
            {
                tvOutputViewer.Nodes.Clear();
                TreeNode parent = JSONToTree(obj);
                parent.Text = "PathFinder_JSON_Object";
                tvOutputViewer.Nodes.Add(parent);

                if (!parent.IsExpanded)
                    parent.Expand();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        // From https://stackoverflow.com/questions/18769634/creating-tree-view-dynamically-according-to-json-text-in-winforms
        private TreeNode JSONToTree(JObject obj)
        {
            //create the parent node
            TreeNode parent = new TreeNode();
            //loop through the obj. all token should be pair<key, value>
            foreach (var token in obj)
            {
                //change the display Content of the parent
                parent.Text = token.Key.ToString();
                parent.Tag = token.Key.ToString();
                //create the child node
                TreeNode child = new TreeNode();
                child.Text = token.Key.ToString();
                child.Tag = token.Key.ToString();
                //check if the value is of type obj recall the method
                if (token.Value.Type.ToString() == "Object")
                {
                    // child.Text = token.Key.ToString();
                    //create a new JObject using the the Token.value
                    JObject o = (JObject)token.Value;
                    //recall the method
                    child = JSONToTree(o);

                    child.Text = token.Key.ToString();
                    //add the child to the parentNode
                    parent.Nodes.Add(child);
                }
                //if type is of array
                else if (token.Value.Type.ToString() == "Array")
                {
                    int ix = -1;
                    //  child.Text = token.Key.ToString();
                    //loop though the array
                    foreach (var itm in token.Value)
                    {
                        //check if value is an Array of objects
                        if (itm.Type.ToString() == "Object")
                        {
                            TreeNode objTN = new TreeNode();
                            //child.Text = token.Key.ToString();
                            //call back the method
                            ix++;

                            JObject o = (JObject)itm;
                            objTN = JSONToTree(o);
                            objTN.Text = token.Key.ToString() + "[" + ix + "]";
                            objTN.Tag = token.Key.ToString() + "[" + ix + "]";
                            //child.Nodes.Add(objTN);
                            parent.Nodes.Add(objTN);
                        }
                        //regular array string, int, etc
                        else if (itm.Type.ToString() == "Array")
                        {
                            ix++;
                            TreeNode dataArray = new TreeNode();
                            foreach (var data in itm)
                            {
                                dataArray.Text = token.Key.ToString() + "[" + ix + "]";
                                dataArray.Nodes.Add(data.ToString());
                            }
                            child.Nodes.Add(dataArray);
                        }
                        else
                        {
                            child.Nodes.Add(itm.ToString());
                        }
                    }
                    parent.Nodes.Add(child);
                }
                else
                {
                    //if token.Value is not nested
                    // child.Text = token.Key.ToString();
                    //change the value into N/A if value == null or an empty string
                    if (token.Value.ToString() == "")
                        child.Nodes.Add("N/A");
                    else
                        child.Nodes.Add(token.Value.ToString());
                    parent.Nodes.Add(child);
                }
            }
            return parent;
        }

        #endregion Methods

        #region Context Menu

        private void rtbInputJson_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                rtbInputJson.ContextMenu = AddContextMenu(rtbInputJson);
            }
        }

        private void rtbSelectedPaths_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                rtbSelectedPaths.ContextMenu = AddContextMenu(rtbSelectedPaths);
            }
        }

        private ContextMenu AddContextMenu(RichTextBox richTextBox)
        {
            ContextMenu contextMenu = new System.Windows.Forms.ContextMenu();

            if (richTextBox == null)
                return contextMenu;

            MenuItem menuItem = new MenuItem("Clear Text");
            menuItem.Click += delegate (object s2, EventArgs e2)
            {
                richTextBox.Clear();
            };
            contextMenu.MenuItems.Add(menuItem);

            menuItem = new MenuItem("Cut");
            menuItem.Click += delegate (object s2, EventArgs e2)
            {
                richTextBox.Cut();
            };
            contextMenu.MenuItems.Add(menuItem);
            menuItem = new MenuItem("Copy");
            menuItem.Click += delegate (object s2, EventArgs e2)
            {
                Clipboard.SetData(DataFormats.Rtf, rtbInputJson.SelectedRtf);
            };
            contextMenu.MenuItems.Add(menuItem);
            menuItem = new MenuItem("Paste");
            menuItem.Click += delegate (object s2, EventArgs e2)
            {
                if (Clipboard.ContainsText())
                {
                    int selstart = rtbInputJson.SelectionStart;
                    if (richTextBox.SelectedText != null && richTextBox.SelectedText != "")
                    {
                        richTextBox.Text = richTextBox.Text.Remove(selstart, richTextBox.SelectionLength);
                    }

                    string clip = Clipboard.GetText(TextDataFormat.Text).ToString();
                    richTextBox.Text = richTextBox.Text.Insert(selstart, clip);

                    richTextBox.SelectionStart = selstart + clip.Length;

                    if (richTextBox.Name == "rtbInputJson")
                        ParseJSONFromInput(rtbInputJson.Text);
                }
            };
            contextMenu.MenuItems.Add(menuItem);

            return contextMenu;
        }

        #endregion Context Menu
    }
}