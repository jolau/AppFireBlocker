using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NetFwTypeLib;
using System.IO;


namespace ProgrammWallBlocker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void addBlockRule(string strAppPath, string strGroupName, string strRuleName, bool bolInbound, bool bolOutbound)
        {
            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));

            if (bolInbound)
            {
                INetFwRule firewallRuleIn = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
                firewallRuleIn.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
                firewallRuleIn.Description = "Block" + strRuleName;
                firewallRuleIn.ApplicationName = strAppPath;
                firewallRuleIn.Enabled = true;
                firewallRuleIn.InterfaceTypes = "All";
                firewallRuleIn.Grouping = strGroupName;
                firewallRuleIn.Name = strRuleName;
                firewallRuleIn.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN;
                firewallPolicy.Rules.Add(firewallRuleIn);
            }

            if (bolOutbound)
            {
                INetFwRule firewallRuleOut = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
                firewallRuleOut.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
                firewallRuleOut.Description = "Block" + strRuleName;
                firewallRuleOut.ApplicationName = strAppPath;
                firewallRuleOut.Enabled = true;
                firewallRuleOut.InterfaceTypes = "All";
                firewallRuleOut.Grouping = strGroupName;
                firewallRuleOut.Name = strRuleName;
                firewallRuleOut.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
                firewallPolicy.Rules.Add(firewallRuleOut);
            }

        }

        private void delBlockRule(string strRuleName)
        {
            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            firewallPolicy.Rules.Remove(strRuleName);
        }

        private void btnBrowseDir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog fdbBrowseDir = new FolderBrowserDialog();
            fdbBrowseDir.Description = "Browse directory";
            if (tbPath.Text == "")
            {
                fdbBrowseDir.SelectedPath = @"C:\Program Files";
            }
            else
            {
                fdbBrowseDir.SelectedPath = tbPath.Text;
            }

            DialogResult fdbResult = fdbBrowseDir.ShowDialog(this);
            if (fdbResult == DialogResult.OK)
            {
                tbPath.Text = fdbBrowseDir.SelectedPath;
            }

        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            ofdFileDir.RestoreDirectory = true;
            DialogResult ofdResult = ofdFileDir.ShowDialog(this);
            if (ofdResult == DialogResult.OK)
            {
                tbPath.Text = "";
                foreach (string strName in ofdFileDir.FileNames)
                {
                    tbPath.Text += strName + "; ";
                }
            }
        }

        private void btnAddRoules_Click(object sender, EventArgs e)
        {
            int intCounter = 0;
            if (cbOutboundRule.Checked || cbInboundRule.Checked)
            {
                if (tbPath.Text != "")
                {
                    if (tbPath.Text.Contains(';'))
                    {
                        tbPath.Text.Replace(" ;", ";");
                        string[] strPaths = tbPath.Text.Split(';');

                        for (int i = 0; i < strPaths.Length - 1; i++)
                        {
                            addBlockRule(strPaths[i], "", strPaths[i].Split('\\').Last(), cbInboundRule.Checked, cbOutboundRule.Checked);
                            intCounter++;
                        }
                    }
                    else
                    {
                        List<string> ExecutePaths = getExecuteFiles(tbPath.Text);

                        foreach (string strExecutePath in ExecutePaths)
                        {
                            addBlockRule(strExecutePath, tbPath.Text.Split('\\').Last(), strExecutePath.Split('\\').Last(), cbInboundRule.Checked, cbOutboundRule.Checked);
                            intCounter++;
                        }
                    }
                }
                MessageBox.Show("Done! " + intCounter.ToString() + " Rules were added.");
            }
            else
            {
                MessageBox.Show("You have to choose at least one rule option!");
            }
        }

        private List<string> getExecuteFiles(string strInputPath)
        {
            List<string> ExFileArray = new List<string>();
            foreach (string strPath in GetFileList(strInputPath, true))
            {
                if (strPath.EndsWith(".exe"))
                {
                    ExFileArray.Add(strPath);
                }

                if (strPath.EndsWith(".jar"))
                {
                    ExFileArray.Add(strPath);
                }
            }

            return ExFileArray;
        }

        public List<string> GetFileList(string Root, bool SubFolders)
        {
            List<string> FileArray = new List<string>();
            try
            {
                string[] Files = System.IO.Directory.GetFiles(Root);
                string[] Folders = System.IO.Directory.GetDirectories(Root);

                for (int i = 0; i < Files.Length; i++)
                {
                    FileArray.Add(Files[i].ToString());
                }

                if (SubFolders == true)
                {
                    for (int i = 0; i < Folders.Length; i++)
                    {
                        FileArray.AddRange(GetFileList(Folders[i], SubFolders));
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("The path is invalid or you don't have enough permissions to open this directory." + "\n" + "\n" + "Description:" + "\n" + Ex.Message);
            }
            return FileArray;
        }

        private void btnDeleteRoule_Click(object sender, EventArgs e)
        {
            for (int n = 0; n <= 2; n++)
            {
                if (tbPath.Text != "")
                {
                    if (tbPath.Text.Contains(';'))
                    {
                        tbPath.Text.Replace(" ;", ";");
                        string[] strPaths = tbPath.Text.Split(';');

                        for (int i = 0; i < strPaths.Length - 1; i++)
                        {
                            delBlockRule(strPaths[i].Split('\\').Last());
                        }
                    }
                    else
                    {
                        List<string> ExecutePaths = getExecuteFiles(tbPath.Text);

                        foreach (string strExecutePath in ExecutePaths)
                        {
                            delBlockRule(strExecutePath.Split('\\').Last());
                        }
                    }
                }
            }

            MessageBox.Show("Done!");
        }

    }
}
