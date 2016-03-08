// PROJECT : NJL.OdataGenerator
// This plugin was developed by Nizar JLASSI

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using McTools.Xrm.Connection;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata.Query;
using Microsoft.Xrm.Sdk.Query;
using XrmToolBox;
using NJL.OdataGenerator.Helpers;
using NJL.OdataGenerator.AppCode;
using Microsoft.Xrm.Sdk.Metadata;
using XrmToolBox.Attributes;
using System.Text;
using System.Data;
using System.Linq;


[assembly: BackgroundColor("Black")]
[assembly: PrimaryFontColor("Green")]
[assembly: SecondaryFontColor("Green")]
[assembly: SmallImageBase64("/9j/4AAQSkZJRgABAQAAAQABAAD/2wBDAAYEBQYFBAYGBQYHBwYIChAKCgkJChQODwwQFxQYGBcUFhYaHSUfGhsjHBYWICwgIyYnKSopGR8tMC0oMCUoKSj/2wBDAQcHBwoIChMKChMoGhYaKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCj/wAARCAAgACADASIAAhEBAxEB/8QAFwABAQEBAAAAAAAAAAAAAAAACAcFAv/EACwQAAEEAQIFAwMFAQAAAAAAAAECAwQFEQAGBxUhQWESE4JCUXEUIiQxUoH/xAAWAQEBAQAAAAAAAAAAAAAAAAAABQH/xAAaEQACAwEBAAAAAAAAAAAAAAABAgADERIE/9oADAMBAAIRAxEAPwA1VVdNvrVEaKhx+U+vAA6lROqpG4Y11ayObyZ0uX3armPWhHguHofjnWHsZzke0LW4Y/bPfcRAZc7thQKnCPOAB8jpFUO9FbB4Y09jfLXOdmN/xo6cANtjzjU6+1y3IOASV6LnZ+VOASIyeGNdZNHk8udEl/Q1Zse2hfgODoD+calltXTqC2XGlNuR5TDmCD0KSNL3dm71774U2lpQLciGKkCVGICgtB+xxo+77c59s2nun+s9hxcCQ53cCAC2T5wSPiNKLnDYTojzXOr8sdE42I3zzadrTMdZzDiJ7DfdwIBDgHnBB+J0i6DZit+cMKeu3EhcNyK3mNJSQfW2f6yM6HdXPm0domTFU4xLYXkEdCgjVPjcTK6yZHO4UuPK7v1z/thfkoIIz+MaX0uG6A0TPTRYr9KNEuO79oL2NwqtKvbza5P6lIMqSsgYQPsM6Pe/W+QbPp6N/pOdcXPkN92/WAEJPnAz/wBGtWTxOrqxkmlgSpEr6H7F/wBwNn/QQABn851LrSfNvbVciUtyRLfcySepWo6UUuW0jBHmodn6YYBP/9k=")]
[assembly: BigImageBase64("/9j/4AAQSkZJRgABAQAAAQABAAD/2wBDAAYEBQYFBAYGBQYHBwYIChAKCgkJChQODwwQFxQYGBcUFhYaHSUfGhsjHBYWICwgIyYnKSopGR8tMC0oMCUoKSj/2wBDAQcHBwoIChMKChMoGhYaKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCj/wAARCABKAEoDASIAAhEBAxEB/8QAHAAAAQQDAQAAAAAAAAAAAAAABwAFBggCAwQB/8QAQBAAAAUCAgQJCQUJAAAAAAAAAAIDBAUBBgcSERMiQhQVITEyQVJygQgWIzNDUWFxkReSsbLwJDRUYmNzgsHR/8QAGgEAAgMBAQAAAAAAAAAAAAAAAwUBAgQABv/EACQRAAICAgICAgIDAAAAAAAAAAECAAMEERIhMVETQQUyImHB/9oADAMBAAIRAxEAPwCqgyCHS1bnXU+IgkDsyGYKNmaU06nHWkwUPuglYf4ZSly11yZSNmJPWultkhf+gh0icPbW2FyO598XpZdlL9fUYrMwKeotuzwp0JXmkUp2RpUjlCbosZ552oSuROxWmT+Y3L+A2ZcObl2F493Brm9qntE8QEZp35gB+RO/MrIdE6Y1g133hM9iG3GMaqSSijdFdHdp8aARP2Z0FBtqyFs6+4wpyVtjeMgggfc1TNImdQFXCGzPOKX/AGuupjmpdc6V6ikp1eIG0YnrFQeZBXzQwdjmjfYfTqlVlzb2ppzU/XxGHKsP6iLs2w/oJM4qbjrvn07daK8X243TqUpEzZdZo66icN8JrXX2UHpz901BV+yW7qUm0G7XNrFT0KX6i4sOwi7Dtsjh8emsIXbVN0jV+AwJWrORYoIHZPqK6qlawi1QVHZJ+ox/YrA9tb7w518Jbaa7K7s5O8ag0KY4xZH2q4OfV9oS8/FF/wBvnM1Pynp0i9ItdAJ8eLYCKl2fR3DfHh2gihQW9HY3A9cMs1w4uRBjGuOHw7hPMugY2anLWtK+IHWMtnMkE2s/b+3DyG0XL7M/ZDRiTHuoSectHXrElMve+ImOE7oly2nP2k728yFXbXNunpz6P17wKnajkOoGjko5Dr+vUrq5TyKDSHmeb6lyfvBmDutuSgz0FT81BjtCU9KDNjhXIlaqKfqyRZMvjzgKxJ9WqDliMnx3hvas4ht8HSqwXy7pqcwwZPVm4uy+rAZn5OCCa18taqbhTGL89AJvlMvnSKbFunm1GUxv8gDMKpo8DdDV3uJH2u71i2F7221xAttBVoqXWaMyRvDmGcjmj1r56OvcyFTZXZWnnYOvYlFVZB1w7e5xZfyZn7k8iu3rm1Bksxu8IqpgrNcZZOBb3SzbIOmGlmoWNEruHxya81No3Zp7hyH5XUqugvkzqz81iFV48fJgV8qRugS7CHJ0zoUzfWoifk+qHJiGxITfIoU3yyVHuN1wecV0OnBPUFNq0vlQOWAbLgr6Vn19hrGtDmz9WetOSn00jgwYEj7MgMGUsPsmCq/UyJz8iRPoFXP+aoh4kNzuuFPV1u2pU31rpEeDPHGkEc4o1WJubKZFAc8GZxlIsn1pTh8jGSL6AxvZrdVfEAYOsU/O0UIYhuURkVcxsSuVT8i7HmWBtLD8jS+uKLgOdFAhTGKqXZze6tKiw1sR8VbyWpay+dDsqKUNQV0tPEmLm4lCJvUh9guVB+n00/n1h4kLGlF0+EWxJN5Zqfo6tXKfxpWoUbap+XHZiP8AlQ/IJs+/uWW44jv41L71AxXKhFzyVEV5XIh2E1aFzCs9bUvTWZOKn3+g+RVg3IonrphwlFNN47hfl+mkEfLssXiybELZnXWrwevqNuJFkNSXa0j7cMd5wgnazZa6dHP7gsSnbaxbKRtCNVId849NIql/L+A7pm+7fslmu0tQ/D5U5cqkgpzF7or9cU0vIul1V1TqKKmzGMYWx6WY+JbGoZz41/kan6+sUHGEaumoQcKoUaj5F4jQmIy0hBCZadTd2dMSCIuh7HKZ2jtZE/8ATNUoiwXUBPSr+YF6Es8iE0mKt0ETycdu/vBjmLyk5T9+kHDn+4pUwhwxMBjGTcEMSud7h+dTeHFWo8HhgdVC9CaVQKNCehBDEWlp/9k=")]
namespace NJL.OdataGenerator
{
    public partial class OdataGenerator : PluginBase, ICodePlexPlugin//, IGitHubPlugin, IPayPalPlugin
    {
        private IOrganizationService service;

        private Panel infoPanel;

        /// <summary>
        /// List of attributes that will appear in $select= part of the ODATA Query URL.
        /// </summary>
        private List<string> selectingAttributesList;

        /// <summary>
        /// List of attributes that will appear in $orderby= part of the ODATA Query URL.
        /// </summary>
        private List<OrderingItem> orderingAttributesList;

        /// <summary>
        /// List of attributes that will appear in filter= part of the ODATA Query URL.
        /// </summary>
        private List<FilteringItem> filteringAttributesList;

        /// <summary>
        /// List of attributes that will appear in $expand= part of the ODATA Query URL.
        /// </summary>
        private List<string> relationshipsExpandList;

        /// <summary>
        /// List of attributes that will appear in $select= part of the ODATA Query URL with the expand part.
        /// </summary>
        private List<ExpandSelectItem> relationshipsExpandSelectingAttributesList;

        /// <summary>
        /// Constructor
        /// </summary>
        public OdataGenerator()
        {
            InitializeComponent();
            
            #region Gridviews's Columns initialization
            gvAttributes.VirtualMode = false;
            
            gvAttributes.Columns.Add("DisplayName", "Display Name");
            gvAttributes.Columns["DisplayName"].FillWeight = 120F;
            gvAttributes.Columns["DisplayName"].ReadOnly = true;
            gvAttributes.Columns["DisplayName"].Width = 120;

            gvAttributes.Columns.Add("SchemaName", "Schema Name");
            gvAttributes.Columns["SchemaName"].FillWeight = 120F;
            gvAttributes.Columns["SchemaName"].ReadOnly = true;
            gvAttributes.Columns["SchemaName"].Width = 120;

            gvAttributes.Columns.Add("AttributeType", "Type");
            gvAttributes.Columns["AttributeType"].FillWeight = 110F;
            gvAttributes.Columns["AttributeType"].ReadOnly = true;
            gvAttributes.Columns["AttributeType"].Width = 110;

            gvAttributes.Columns.Add("gvcSelect", "Select");
            gvAttributes.Columns["gvcSelect"].FillWeight = 50F;
            gvAttributes.Columns["gvcSelect"].Width = 50;
            gvAttributes.Columns["gvcSelect"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            gvAttributes.Columns.Add("gvcFilter", "Filter");
            gvAttributes.Columns["gvcFilter"].FillWeight = 50F;
            gvAttributes.Columns["gvcFilter"].Width = 50;
            gvAttributes.Columns["gvcFilter"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            gvAttributes.Columns.Add("gvcOrder", "Order");
            gvAttributes.Columns["gvcOrder"].FillWeight = 50F;
            gvAttributes.Columns["gvcOrder"].Width = 50;
            gvAttributes.Columns["gvcOrder"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            gvSelectingAttributes.Columns.Add("DispalyNameSA", "Display Name");
            gvSelectingAttributes.Columns["DispalyNameSA"].FillWeight = 200F;
            gvSelectingAttributes.Columns["DispalyNameSA"].ReadOnly = true;
            gvSelectingAttributes.Columns["DispalyNameSA"].Width = 200;

            gvSelectingAttributes.Columns.Add("SchemaNameSA", "Display Name");
            gvSelectingAttributes.Columns["SchemaNameSA"].FillWeight = 200F;
            gvSelectingAttributes.Columns["SchemaNameSA"].ReadOnly = true;
            gvSelectingAttributes.Columns["SchemaNameSA"].Width = 200;

            gvFilteringAttributes.Columns.Add("DisplayNameFA", "Display Name");
            gvFilteringAttributes.Columns["DisplayNameFA"].FillWeight = 110F;
            gvFilteringAttributes.Columns["DisplayNameFA"].ReadOnly = true;
            gvFilteringAttributes.Columns["DisplayNameFA"].Width = 110;

            gvFilteringAttributes.Columns.Add("SchemaNameFA", "Schema Name");
            gvFilteringAttributes.Columns["SchemaNameFA"].FillWeight = 110F;
            gvFilteringAttributes.Columns["SchemaNameFA"].ReadOnly = true;
            gvFilteringAttributes.Columns["SchemaNameFA"].Width = 110;

            gvFilteringAttributes.Columns.Add("OperatorFA", "Operator");
            gvFilteringAttributes.Columns["OperatorFA"].FillWeight = 100F;
            gvFilteringAttributes.Columns["OperatorFA"].Width = 100;

            gvFilteringAttributes.Columns.Add("ValueFA", "Value");
            gvFilteringAttributes.Columns["ValueFA"].FillWeight = 100F;
            gvFilteringAttributes.Columns["ValueFA"].Width = 100;

            gvOrderingAttributes.Columns.Add("DisplayNameOA", "Display Name");
            gvOrderingAttributes.Columns["DisplayNameOA"].FillWeight = 160F;
            gvOrderingAttributes.Columns["DisplayNameOA"].ReadOnly = true;
            gvOrderingAttributes.Columns["DisplayNameOA"].Width = 160;

            gvOrderingAttributes.Columns.Add("SchemaNameOA", "Schema Name");
            gvOrderingAttributes.Columns["SchemaNameOA"].FillWeight = 160F;
            gvOrderingAttributes.Columns["SchemaNameOA"].ReadOnly = true;
            gvOrderingAttributes.Columns["SchemaNameOA"].Width = 160;

            gvOrderingAttributes.Columns.Add("Orderway", "Order By");
            gvOrderingAttributes.Columns["Orderway"].FillWeight = 1110F;
            gvOrderingAttributes.Columns["Orderway"].Width = 110;

            gvExpand.Columns.Add("SelectEx", "Sel.");
            gvExpand.Columns["SelectEx"].FillWeight = 35F;
            gvExpand.Columns["SelectEx"].Width = 35;

            gvExpand.Columns.Add("gvcDisplayNameEx", "Display Name");
            gvExpand.Columns["gvcDisplayNameEx"].FillWeight = 105F;
            gvExpand.Columns["gvcDisplayNameEx"].Width = 105;
            gvExpand.Columns["gvcDisplayNameEx"].ReadOnly = true;

            gvExpand.Columns.Add("gvcSchemaNameEx", "Schema Name");
            gvExpand.Columns["gvcSchemaNameEx"].FillWeight = 105F;
            gvExpand.Columns["gvcSchemaNameEx"].Width = 105;
            gvExpand.Columns["gvcSchemaNameEx"].ReadOnly = true;

            gvExpand.Columns.Add("gvcRelationShip", "RelationShip");
            gvExpand.Columns["gvcRelationShip"].FillWeight = 210F;
            gvExpand.Columns["gvcRelationShip"].Width = 210;
            gvExpand.Columns["gvcRelationShip"].ReadOnly = true;

            gvExpandAttributes.Columns.Add("DisplayNameEx", "Display Name");
            gvExpandAttributes.Columns["DisplayNameEx"].FillWeight = 200F;
            gvExpandAttributes.Columns["DisplayNameEx"].Width = 200;
            gvExpandAttributes.Columns["DisplayNameEx"].ReadOnly = true;

            gvExpandAttributes.Columns.Add("SchemaNameEx", "Schema Name");
            gvExpandAttributes.Columns["SchemaNameEx"].FillWeight = 200F;
            gvExpandAttributes.Columns["SchemaNameEx"].Width = 200;
            gvExpandAttributes.Columns["SchemaNameEx"].ReadOnly = true;
            
            
            #endregion

        }

        public string UserName
        {
            get { return "GithubUserName"; }
        }

        public string RepositoryName
        {
            get { return "GithubRepositoryName"; }
        }

        public string CodePlexUrlName
        {
            get { return "CodePlex"; }
        }

        public string EmailAccount
        {
            get { return "paypal@paypal.com"; }
        }

        public string DonationDescription
        {
            get { return "paypal description"; }
        }

        /// <summary>
        /// Close button
        /// </summary>
        private void tsbCloseThisTab_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        /// <summary>
        /// Call the LoadEntities() method
        /// </summary>
        private void tsbLoadEntities_Click(object sender, EventArgs e)
        {
            ExecuteMethod(LoadEntities);
        }

        /// <summary>
        /// Load All entities in the ComboBox cbEntities
        /// </summary>
        private void LoadEntities()
        {

            cbxEntities.Enabled = true;
            cbxEntities.Items.Clear();
            tsbLoadAttributes.Enabled = false;
            tsbGenerateOdata.Enabled = false;

            WorkAsync("Loading entities...",
                e =>
                {
                    e.Result = MetadataHelper.RetrieveEntities(Service);
                },
                e =>
                {
                    if (e.Error != null)
                    {
                        string errorMessage = XrmToolBox.CrmExceptionHelper.GetErrorMessage(e.Error, true);
                        MessageBox.Show(ParentForm, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cbxEntities.Enabled = true;
                        var items = new List<ComboBoxItem>();
                        foreach (EntityMetadata emd in (List<EntityMetadata>)e.Result)
                        {
                            var item = new ComboBoxItem(emd.DisplayName.UserLocalizedLabel.Label, emd);
                            items.Add(item);
                        }

                        items.Sort((x, y) => string.Compare(x.Text, y.Text));

                        cbxEntities.Items.AddRange(items.ToArray());

                    }
                });
        }

        /// <summary>
        /// Fires when the cbEntities' selected value changes
        /// </summary>
        private void cbxEntities_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxEntities.Enabled = false;
            tsbLoadAttributes.Enabled = true;
            tsbGenerateOdata.Enabled = true;
        }

        /// <summary>
        /// Load Entity's attributes and (1:N / N:N) relationships
        /// </summary>
        private void tsbLoadAttributes_Click(object sender, EventArgs e)
        {
            gvAttributes.Rows.Clear();
            gvSelectingAttributes.Rows.Clear();
            gvFilteringAttributes.Rows.Clear();
            gvOrderingAttributes.Rows.Clear();

            WorkAsync("Loading Attributes...",
                ev =>
                {
                    ev.Result = MetadataHelper.RetrieveEntityAttributes(((EntityMetadata)(((ComboBoxItem)cbxEntities.SelectedItem).Value)).LogicalName, Service);
                },
                ev =>
                {
                    if (ev.Error != null)
                    {
                        string errorMessage = XrmToolBox.CrmExceptionHelper.GetErrorMessage(ev.Error, true);
                        MessageBox.Show(ParentForm, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var items = new List<DataGridViewRow>();
                        foreach (AttributeMetadata amd in ((EntityMetadata)ev.Result).Attributes)
                        {
                            if (amd.AttributeType.HasValue
                                && amd.AttributeType.Value != AttributeTypeCode.Virtual
                                && string.IsNullOrEmpty(amd.AttributeOf))
                            {
                                string label = amd.DisplayName.UserLocalizedLabel != null ? amd.DisplayName.UserLocalizedLabel.Label : "N/A";

                                var item = new DataGridViewRow();

                                DataGridViewTextBoxCell c1 = new DataGridViewTextBoxCell();
                                c1.Value = label;

                                DataGridViewTextBoxCell c2 = new DataGridViewTextBoxCell();
                                c2.Value = amd.SchemaName;

                                DataGridViewTextBoxCell c3 = new DataGridViewTextBoxCell();
                                c3.Value = (amd.AttributeType.HasValue) ? amd.AttributeType.ToString() : "N/A";


                                DataGridViewCheckBoxCell c4 = new DataGridViewCheckBoxCell();
                                c4.Value = false;

                                DataGridViewCheckBoxCell c5 = new DataGridViewCheckBoxCell();
                                c5.Value = false;

                                DataGridViewCheckBoxCell c6 = new DataGridViewCheckBoxCell();
                                c6.Value = false;

                                item.Cells.Add(c1);
                                item.Cells.Add(c2);
                                item.Cells.Add(c3);
                                item.Cells.Add(c4);
                                item.Cells.Add(c5);
                                item.Cells.Add(c6);

                                item.Tag = amd;

                                items.Add(item);
                            }
                        }
                        gvAttributes.Rows.AddRange(items.ToArray());


                        WorkAsync("Loading RelationShips...",
                           evr =>
                           {
                               evr.Result = MetadataHelper.RetrieveEntityRelationShips(((EntityMetadata)(((ComboBoxItem)cbxEntities.SelectedItem).Value)).LogicalName, Service);
                           },
                           evr =>
                           {
                               if (evr.Error != null)
                               {
                                   string errorMessage = XrmToolBox.CrmExceptionHelper.GetErrorMessage(evr.Error, true);
                                   MessageBox.Show(ParentForm, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                               }
                               else
                               {
                                   
                                   var cbItems = new List<ComboBoxItem>();
                                   foreach (OneToManyRelationshipMetadata emd in ((EntityMetadata)evr.Result).OneToManyRelationships)
                                   {
                                       var item = new ComboBoxItem(string.Format("(1:N) {0}", emd.SchemaName), emd);
                                       cbItems.Add(item);
                                   }

                                   foreach (ManyToManyRelationshipMetadata emd in ((EntityMetadata)evr.Result).ManyToManyRelationships)
                                   {
                                       var item = new ComboBoxItem(string.Format("(N:N) {0}", emd.SchemaName), emd);
                                       cbItems.Add(item);
                                   }

                                   cbItems.Sort((x, y) => string.Compare(x.Text, y.Text));

                                   cbxlRelationships.Items.AddRange(cbItems.ToArray());
                               }

                           });

                    }

                });
        }

        /// <summary>
        /// Allows only numerics in txtTop textbox
        /// </summary>
        private void txtTop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Allows only numerics in txtSkip textbox
        /// </summary>
        private void txtSkip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Add attributes to Select / Filter / Order By gridviews
        /// </summary>
        private void gvAttributes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) // Add To Selection Attributes
            {
                #region Add To Selection Attributes Processing
                bool isChecked = (Boolean)gvAttributes[3, e.RowIndex].FormattedValue;

                var displayName = (string)gvAttributes[0, e.RowIndex].FormattedValue.ToString();
                var schemaName = (string)gvAttributes[1, e.RowIndex].FormattedValue.ToString();

                var row = new DataGridViewRow();

                DataGridViewTextBoxCell c1 = new DataGridViewTextBoxCell();
                c1.Value = displayName;

                DataGridViewTextBoxCell c2 = new DataGridViewTextBoxCell();
                c2.Value = schemaName;

                row.Cells.Add(c1);
                row.Cells.Add(c2);

                if (isChecked)
                {
                    gvSelectingAttributes.Rows.Add(row);

                    if (selectingAttributesList == null) selectingAttributesList = new List<string>();
                    selectingAttributesList.Add(schemaName);
                }
                else
                {
                    gvSelectingAttributes.Rows.Remove(row);

                    selectingAttributesList.Remove(schemaName);
                }
                #endregion
            }
            else if (e.ColumnIndex == 4) // Add To Filtering Attributes
            {
                #region Add To Filtering Attributes Processing
                bool isChecked = (Boolean)gvAttributes[4, e.RowIndex].FormattedValue;

                var displayName = (string)gvAttributes[0, e.RowIndex].FormattedValue.ToString();
                var schemaName = (string)gvAttributes[1, e.RowIndex].FormattedValue.ToString();


                var row = new DataGridViewRow();

                DataGridViewTextBoxCell c1 = new DataGridViewTextBoxCell();
                c1.Value = displayName;

                DataGridViewTextBoxCell c2 = new DataGridViewTextBoxCell();
                c2.Value = schemaName;

                DataGridViewComboBoxCell c3;

                AttributeMetadata am = (AttributeMetadata)gvAttributes.Rows[e.RowIndex].Tag;

                FilteringItem fi = new FilteringItem() { SchemaName = schemaName, Atc = am.AttributeType.Value, Operator = "Equals", Value = string.Empty };


                row.Cells.Add(c1);
                row.Cells.Add(c2);

                if (am.AttributeType.HasValue && am.AttributeType.Value == AttributeTypeCode.String || am.AttributeType.Value == AttributeTypeCode.Memo) // String Type Processing
                {

                    c3 = FillComboBox(AttributeTypeCode.String);
                    DataGridViewTextBoxCell c4 = new DataGridViewTextBoxCell();
                    c4.Value = "";

                    row.Cells.Add(c3);
                    row.Cells.Add(c4);

                }
                else if (am.AttributeType.HasValue && am.AttributeType.Value == AttributeTypeCode.Boolean) // Boolean Type Processing
                {

                    c3 = FillComboBox(AttributeTypeCode.Boolean);

                    DataGridViewComboBoxCell c4 = new DataGridViewComboBoxCell();

                    c4.Items.Add(new ComboBoxItem("True", true));
                    c4.Items.Add(new ComboBoxItem("False", false));

                    row.Cells.Add(c3);
                    row.Cells.Add(c4);

                }
                else if (am.AttributeType.HasValue && am.AttributeType.Value == AttributeTypeCode.DateTime) // DateTime Type Processing
                {

                    c3 = FillComboBox(AttributeTypeCode.DateTime);
                    CalendarCell c4 = new CalendarCell();


                    row.Cells.Add(c3);
                    row.Cells.Add(c4);

                }
                else if (am.AttributeType.HasValue && (am.AttributeType.Value == AttributeTypeCode.Picklist || am.AttributeType.Value == AttributeTypeCode.Status
                                                    || am.AttributeType.Value == AttributeTypeCode.State)) // OptionSet Type Processing
                {
                    var logicalName = ((EntityMetadata)(((ComboBoxItem)cbxEntities.SelectedItem).Value)).LogicalName;
                    c3 = FillComboBox(AttributeTypeCode.Picklist);

                    List<OptionSetItem> osi = new List<OptionSetItem>();
                    if (am.AttributeType.Value == AttributeTypeCode.Picklist)
                        osi = MetadataHelper.GetOptionSetTextsAndValues(schemaName.ToLower(), logicalName, Service);
                    else if (am.AttributeType.Value == AttributeTypeCode.Status)
                        osi = MetadataHelper.GetStatusCodeTextsAndValues(logicalName, Service);
                    else if (am.AttributeType.Value == AttributeTypeCode.State)
                        osi = MetadataHelper.GetStateCodeTextsAndValues(logicalName, Service);


                    DataGridViewComboBoxCell c4 = new DataGridViewComboBoxCell();

                    osi.ForEach(delegate(OptionSetItem o)
                    {
                        c4.Items.Add(new ComboBoxItem(o.Text, o.Value));
                    });

                    row.Cells.Add(c3);
                    row.Cells.Add(c4);
                }
                else if (am.AttributeType.HasValue && (am.AttributeType.Value == AttributeTypeCode.BigInt || am.AttributeType.Value == AttributeTypeCode.Decimal
                                                    || am.AttributeType.Value == AttributeTypeCode.Double || am.AttributeType.Value == AttributeTypeCode.Integer
                                                    || am.AttributeType.Value == AttributeTypeCode.Money)) // Numeric Types Processing
                {
                    var logicalName = ((EntityMetadata)(((ComboBoxItem)cbxEntities.SelectedItem).Value)).LogicalName;
                    c3 = FillComboBox(am.AttributeType.Value);

                    row.Cells.Add(c3);

                    DataGridViewTextBoxCell c4 = new DataGridViewTextBoxCell();
                    row.Cells.Add(c4);
                }
                else if (am.AttributeType.HasValue && am.AttributeType.Value == AttributeTypeCode.Uniqueidentifier || am.AttributeType.Value == AttributeTypeCode.Lookup
                                                   || am.AttributeType.Value == AttributeTypeCode.Owner || am.AttributeType.Value == AttributeTypeCode.Customer) // Guid Types Processing
                {

                    c3 = FillComboBox(am.AttributeType.Value);
                    DataGridViewTextBoxCell c4 = new DataGridViewTextBoxCell();
                    c4.Value = "";

                    row.Cells.Add(c3);
                    row.Cells.Add(c4);

                }
                row.Tag = am;



                if (isChecked)
                {
                    gvFilteringAttributes.Rows.Add(row);

                    if (filteringAttributesList == null) filteringAttributesList = new List<FilteringItem>();
                    filteringAttributesList.Add(fi);
                }
                else
                {
                    gvFilteringAttributes.Rows.Remove(row);

                    filteringAttributesList.Remove(fi);
                }

                #endregion
            }
            else if (e.ColumnIndex == 5) // Add To Ordering Attributes
            {
                #region Add To Ordering Attributes Processing
                bool isChecked = (Boolean)gvAttributes[5, e.RowIndex].FormattedValue;

                var displayName = (string)gvAttributes[0, e.RowIndex].FormattedValue.ToString();
                var schemaName = (string)gvAttributes[1, e.RowIndex].FormattedValue.ToString();

                var row = new DataGridViewRow();

                DataGridViewTextBoxCell c1 = new DataGridViewTextBoxCell();
                c1.Value = displayName;

                DataGridViewTextBoxCell c2 = new DataGridViewTextBoxCell();
                c2.Value = schemaName;

                DataGridViewComboBoxCell c3 = new DataGridViewComboBoxCell();
                c3.Items.Add("Asc");
                c3.Items.Add("Desc");
                c3.Value = "Asc";


                row.Cells.Add(c1);
                row.Cells.Add(c2);
                row.Cells.Add(c3);


                OrderingItem oi = new OrderingItem();
                oi.SchemaName = schemaName;
                oi.Order = "Asc";

                if (isChecked)
                {
                    gvOrderingAttributes.Rows.Add(row);

                    if (orderingAttributesList == null) orderingAttributesList = new List<OrderingItem>();
                    orderingAttributesList.Add(oi);
                }
                else
                {
                    gvOrderingAttributes.Rows.Remove(row);

                    orderingAttributesList.Remove(oi);
                }
                #endregion
            }
        }

        /// <summary>
        /// returns a <b>DataGridViewComboBoxCell</b> object containing the apropriate combobox values according to the <b>AttributeTypeCode</b> entry.
        /// </summary>
        /// <param name="atc"><b>AttributeTypeCode</b> object</param>
        /// <returns><b>DataGridViewComboBoxCell</b> object</returns>
        private DataGridViewComboBoxCell FillComboBox(AttributeTypeCode atc)
        {
            DataGridViewComboBoxCell c = new DataGridViewComboBoxCell();
            switch (atc)
            {
                case AttributeTypeCode.String:
                case AttributeTypeCode.Memo:

                    c.Items.Add("Equal");
                    c.Items.Add("Not Equal");
                    c.Items.Add("Ends With");
                    c.Items.Add("Starts With");
                    c.Items.Add("Substring Of");

                    c.Value = "Equal";
                    break;

                case AttributeTypeCode.Boolean:
                case AttributeTypeCode.Uniqueidentifier:
                case AttributeTypeCode.Lookup:
                case AttributeTypeCode.Owner:
                case AttributeTypeCode.Customer:
                case AttributeTypeCode.Picklist:
                case AttributeTypeCode.State:
                case AttributeTypeCode.Status:

                    c.Items.Add("Equal");
                    c.Items.Add("Not Equal");

                    c.Value = "Equal";
                    break;

                case AttributeTypeCode.DateTime:
                case AttributeTypeCode.BigInt:
                case AttributeTypeCode.Decimal:
                case AttributeTypeCode.Double:
                case AttributeTypeCode.Integer:
                case AttributeTypeCode.Money:

                    c.Items.Add("Equal");
                    c.Items.Add("Not Equal");
                    c.Items.Add("Greater than");
                    c.Items.Add("Greater than or equal");
                    c.Items.Add("Less than");
                    c.Items.Add("Less than or equal");

                    c.Value = "Equal";
                    break;


                default:

                    c.Items.Add("Equal");
                    c.Items.Add("Not Equal");
                    c.Items.Add("Greater than");
                    c.Items.Add("Greater than or equal");
                    c.Items.Add("Less than");
                    c.Items.Add("Less than or equal");
                    c.Items.Add("Contains");
                    c.Items.Add("Ends With");
                    c.Items.Add("Starts With");

                    c.Value = "Equal";
                    break;
            }
            return c;
        }

        /// <summary>
        /// Generate the Odata Query URL
        /// </summary>
        private void tsbGenerateOdata_Click(object sender, EventArgs e)
        {
            string urlPart = ConnectionDetail.OrganizationServiceUrl.Replace("Organization", "OrganizationData");
            string setPart = string.Format("{0}Set?", ((EntityMetadata)(((ComboBoxItem)cbxEntities.SelectedItem).Value)).SchemaName);
            string topPart = string.Empty;
            string skipPart = string.Empty;
            bool isNext = false;

            if (!string.IsNullOrEmpty(txtTop.Text)) topPart = string.Format("$top={0}", txtTop.Text);
            if (!string.IsNullOrEmpty(txtSkip.Text)) skipPart = string.Format("$skip={0}", txtSkip.Text);

            string selectPart = ConstructSelectPart();
            string filterPart = ConstructFilterPart();
            string orderbyPart = ConstructOrderByPart();
            string expandPart = ConstructExpandPart();

            StringBuilder odataQueryUrl = new StringBuilder();
            odataQueryUrl = odataQueryUrl.Append(string.Format("{0}/{1}", urlPart, setPart));

            if (!string.IsNullOrEmpty(topPart))
            {
                odataQueryUrl = odataQueryUrl.Append(topPart);
                isNext = true;
            }

            if (!string.IsNullOrEmpty(skipPart))
            {
                if (isNext) odataQueryUrl = odataQueryUrl.Append(string.Format("&{0}", skipPart));
                else
                {
                    odataQueryUrl = odataQueryUrl.Append(skipPart);
                    isNext = true;
                }
            }

            if (!string.IsNullOrEmpty(selectPart))
            {
                if (isNext) odataQueryUrl = odataQueryUrl.Append(string.Format("&{0}", selectPart));
                else
                {
                    odataQueryUrl = odataQueryUrl.Append(selectPart);
                    isNext = true;
                }
            }


            if (!string.IsNullOrEmpty(expandPart))
            {
                if (isNext) odataQueryUrl = odataQueryUrl.Append(string.Format("&{0}", expandPart));
                else
                {
                    odataQueryUrl = odataQueryUrl.Append(expandPart);
                    isNext = true;
                }
            }

            if (!string.IsNullOrEmpty(filterPart))
            {
                if (isNext) odataQueryUrl = odataQueryUrl.Append(string.Format("&{0}", filterPart));
                else
                {
                    odataQueryUrl = odataQueryUrl.Append(filterPart);
                    isNext = true;
                }
            }

            if (!string.IsNullOrEmpty(orderbyPart))
            {
                if (isNext) odataQueryUrl = odataQueryUrl.Append(string.Format("&{0}", orderbyPart));
                else odataQueryUrl = odataQueryUrl.Append(orderbyPart);
            }

            rtxtOdataQueryUrl.Text = odataQueryUrl.ToString();

        }

        /// <summary>
        /// Construct a <b>string</b> with the Select part of the Odata Query URL
        /// </summary>
        /// <returns><b>string</b> object</returns>
        private string ConstructSelectPart()
        {
            if (selectingAttributesList != null && selectingAttributesList.Count > 0)
            {
                var part = string.Empty;
                selectingAttributesList.ForEach(delegate(string s)
                {
                    part += string.Format("{0},", s);
                });

                if (relationshipsExpandSelectingAttributesList == null  && relationshipsExpandList != null && relationshipsExpandList.Count > 0 && cbxUseExpand.Checked)
                {
                    relationshipsExpandList.ForEach(delegate(string s)
                    {
                        part += string.Format("{0},", s);
                    });
                } 
                
                else if (relationshipsExpandSelectingAttributesList != null && relationshipsExpandSelectingAttributesList.Count > 0 && relationshipsExpandList != null && relationshipsExpandList.Count > 0 && cbxUseExpand.Checked)
                {
                    relationshipsExpandList.ForEach(delegate(string s)
                    {
                        if (!relationshipsExpandSelectingAttributesList.Exists(x => x.RelationShipSchemaName == s))
                        {
                            part += string.Format("{0},", s);
                        }
                        else
                        {
                            relationshipsExpandSelectingAttributesList.FindAll(x => x.RelationShipSchemaName == s).ForEach(delegate(ExpandSelectItem esi)
                            {
                                part += string.Format("{0},", esi.ToString());
                            });
                        }

                    });


                }
                part = part.Substring(0, part.LastIndexOf(','));
                if (part.Length > 1)
                    return string.Format("$select={0}", part);
            }
            return string.Empty;
        }

        /// <summary>
        /// Construct a <b>string</b> with the Filter part of the Odata Query URL
        /// </summary>
        /// <returns><b>string</b> object</returns>
        private string ConstructFilterPart()
        {
            if (filteringAttributesList != null && filteringAttributesList.Count > 0)
            {
                var part = string.Empty;
                filteringAttributesList.ForEach(delegate(FilteringItem fi)
                {
                    part += string.Format(" {0} and", fi.ToString());
                });

                part = part.Substring(0, part.LastIndexOf("and"));
                if (part.Length > 1)
                    return string.Format("$filter={0}", part);
            }
            return string.Empty;
        }

        /// <summary>
        /// Construct a <b>string</b> with the Oder By part of the Odata Query URL
        /// </summary>
        /// <returns><b>string</b> object</returns>
        private string ConstructOrderByPart()
        {
            if (orderingAttributesList != null && orderingAttributesList.Count > 0)
            {
                var part = string.Empty;
                orderingAttributesList.ForEach(delegate(OrderingItem oi)
                {
                    part += string.Format("{0},", oi.ToString());
                });

                part = part.Substring(0, part.LastIndexOf(','));
                if (part.Length > 1)
                    return string.Format("$orderby={0}", part);
            }
            return string.Empty;
        }

        /// <summary>
        /// Construct a <b>string</b> with the Oder By part of the Odata Query URL
        /// </summary>
        /// <returns><b>string</b> object</returns>
        private string ConstructExpandPart()
        {
            if (relationshipsExpandList != null && relationshipsExpandList.Count > 0 && cbxUseExpand.Checked)
            {
                var part = string.Empty;
                relationshipsExpandList.ForEach(delegate(string s)
                {
                    part += string.Format("{0},", s.ToString());
                });

                part = part.Substring(0, part.LastIndexOf(','));
                if (part.Length > 1)
                    return string.Format("$expand={0}", part);
            }
            return string.Empty;
        }

        /// <summary>
        /// Catch and manage gvFilteringAttributes errors
        /// </summary>
        private void gvFilteringAttributes_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            //MessageBox.Show("Error happened " + anError.Context.ToString());

            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Commit error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Cell change");
            }
            if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("parsing error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("leave control error");
            }

            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].Cells[0].Style.BackColor = Color.Red;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }
        }

        /// <summary>
        /// Modifying the filteringAttributesList when any operator or value changes
        /// </summary>
        private void gvFilteringAttributes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 1)
            {
                string schemaName = gvFilteringAttributes.Rows[e.RowIndex].Cells[1].Value.ToString();
                AttributeTypeCode atc = filteringAttributesList.Find(x => x.SchemaName == schemaName).Atc;
                
                    switch(atc)
                            {
                                case AttributeTypeCode.BigInt:
                        case AttributeTypeCode.Decimal:
                        case AttributeTypeCode.Double:
                        case AttributeTypeCode.Integer:
                        case AttributeTypeCode.Memo:
                        case AttributeTypeCode.Money:
                        case AttributeTypeCode.String:
                            filteringAttributesList.Find(x => x.SchemaName == schemaName).Value = gvFilteringAttributes.Rows[e.RowIndex].Cells[3].Value.ToString();
                            break;
                        case AttributeTypeCode.DateTime:
                            var date = gvFilteringAttributes.Rows[e.RowIndex].Cells[3].Value.ToString();
                            DateTime dt = DateTime.MinValue;
                            DateTime.TryParse(date, out dt);
                            //if (dt.CompareTo(DateTime.MinValue) != 0)
                            //    MessageBox.Show(string.Format("{0} format should be a Date", schemaName));
                            //else
                                filteringAttributesList.Find(x => x.SchemaName == schemaName).Value = dt.ToString("yyyy-MM-dd");
                            break;
                        case AttributeTypeCode.Boolean:
                            filteringAttributesList.Find(x => x.SchemaName == schemaName).Value = gvFilteringAttributes.Rows[e.RowIndex].Cells[3].Value.ToString().ToLower();
                            break;
                        case AttributeTypeCode.Uniqueidentifier:
                        case AttributeTypeCode.Lookup:
                        case AttributeTypeCode.Owner:
                        case AttributeTypeCode.Customer:
                            var guid = gvFilteringAttributes.Rows[e.RowIndex].Cells[3].Value.ToString();
                            Guid g = Guid.Empty;
                            Guid.TryParse(guid, out g);
                            //if (g.CompareTo(Guid.Empty) != 0) MessageBox.Show(string.Format("{0} format should be Guid", schemaName));
                            //else
                                filteringAttributesList.Find(x => x.SchemaName == schemaName).Value = g.ToString();
                            break;
                        case AttributeTypeCode.Picklist:
                        case AttributeTypeCode.State:
                        case AttributeTypeCode.Status:

                            ComboBoxItem cbi = ((DataGridViewComboBoxCell)gvFilteringAttributes.Rows[e.RowIndex].Cells[3]).Items.OfType<ComboBoxItem>().ToList().Find(x => x.Text == gvFilteringAttributes.Rows[e.RowIndex].Cells[3].Value.ToString());
                            if(cbi != null) filteringAttributesList.Find(x => x.SchemaName == schemaName).Value = cbi.Value.ToString();
                            else filteringAttributesList.Find(x => x.SchemaName == schemaName).Value = gvFilteringAttributes.Rows[e.RowIndex].Cells[3].Value.ToString();
                            break;
                        default:
                            filteringAttributesList.Find(x => x.SchemaName == schemaName).Value = gvFilteringAttributes.Rows[e.RowIndex].Cells[3].Value.ToString();
                            break;
                            }
                


                filteringAttributesList.Find(x => x.SchemaName == schemaName).Operator = gvFilteringAttributes.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        /// <summary>
        /// If user check this checkbox, the expand goupbox became enabled and the  Odata Query URL display the Expand part
        /// </summary>
        private void cbxUseExpand_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxUseExpand.Checked) gbxExpand.Enabled = true;
            else
            {
                for (int i=0; i < cbxlRelationships.Items.Count; i++)
                {
                    cbxlRelationships.SetItemChecked(i, false);
                }

                gvExpand.Rows.Clear();
                gvExpandAttributes.Rows.Clear();
                gbxExpand.Enabled = false;
            }
        }

        /// <summary>
        /// Load Attributes of the selected 1:N or N:N relationship
        /// </summary>
        private void cbxlRelationships_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            ComboBoxItem item;
            var referencedEntity = string.Empty;

            if (relationshipsExpandList == null) relationshipsExpandList = new List<string>();

            item = (ComboBoxItem)cbxlRelationships.Items[e.Index];

            string schemaNameExpand = item.Text;
            if (schemaNameExpand.StartsWith("(1:N) "))
            {
                //relationshipType = '1'; // One To Many
                schemaNameExpand = schemaNameExpand.Replace("(1:N) ", "");

                OneToManyRelationshipMetadata relationship = (OneToManyRelationshipMetadata)(((ComboBoxItem)item).Value);
                referencedEntity = relationship.ReferencedEntity != ((EntityMetadata)(((ComboBoxItem)cbxEntities.SelectedItem).Value)).LogicalName ? relationship.ReferencedEntity : relationship.ReferencingEntity;
            }
            else if (schemaNameExpand.StartsWith("(N:N) "))
            {
                //relationshipType = 'N'; // Many To Many
                schemaNameExpand = schemaNameExpand.Replace("(N:N) ", "");

                ManyToManyRelationshipMetadata relationship = (ManyToManyRelationshipMetadata)(((ComboBoxItem)item).Value);
                referencedEntity = relationship.Entity2LogicalName != ((EntityMetadata)(((ComboBoxItem)cbxEntities.SelectedItem).Value)).LogicalName ? relationship.Entity2LogicalName : relationship.Entity1LogicalName;
            }

            if (e.NewValue == CheckState.Checked)
            {
                
                if (relationshipsExpandList.Contains(schemaNameExpand)) return;


                if (cbxlRelationships.CheckedItems.Count >= 6)
                {
                    MessageBox.Show("Dynamics CRM does not support more than six relationships to expand.");
                    return;
                }

                relationshipsExpandList.Add(schemaNameExpand);


                WorkAsync("Loading Expand Attributes ...",
                   evr =>
                   {
                       evr.Result = MetadataHelper.RetrieveEntityAttributes(referencedEntity, Service);
                   },
                   evr =>
                   {
                       if (evr.Error != null)
                       {
                           string errorMessage = XrmToolBox.CrmExceptionHelper.GetErrorMessage(evr.Error, true);
                           MessageBox.Show(ParentForm, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       }
                       else
                       {

                           var rows = new List<DataGridViewRow>();
                           foreach (AttributeMetadata amd in ((EntityMetadata)evr.Result).Attributes)
                           {
                               if (amd.AttributeType.HasValue
                                   && amd.AttributeType.Value != AttributeTypeCode.Virtual
                                   && string.IsNullOrEmpty(amd.AttributeOf))
                               {
                                   string label = amd.DisplayName.UserLocalizedLabel != null ? amd.DisplayName.UserLocalizedLabel.Label : "N/A";

                                   var row = new DataGridViewRow();


                                   DataGridViewCheckBoxCell c0 = new DataGridViewCheckBoxCell();
                                   c0.Value = false;

                                   DataGridViewTextBoxCell c1 = new DataGridViewTextBoxCell();
                                   c1.Value = label;

                                   DataGridViewTextBoxCell c2 = new DataGridViewTextBoxCell();
                                   c2.Value = amd.SchemaName;

                                   DataGridViewTextBoxCell c3 = new DataGridViewTextBoxCell();
                                   c3.Value = ((ComboBoxItem)item).Text;



                                   row.Cells.Add(c0);
                                   row.Cells.Add(c1);
                                   row.Cells.Add(c2);
                                   row.Cells.Add(c3);

                                   row.Tag = amd;

                                   rows.Add(row);
                               }
                           }
                           gvExpand.Rows.AddRange(rows.ToArray());
                       }

                   });


            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                if (relationshipsExpandList.Contains(schemaNameExpand))
                {
                    relationshipsExpandList.Remove(schemaNameExpand);
                    
                    foreach(DataGridViewRow dr in gvExpand.Rows.OfType<DataGridViewRow>().ToArray())
                    {
                        if(dr.Cells[3].Value == ((ComboBoxItem)item).Text)
                        {
                            gvExpand.Rows.Remove(dr);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Add Expand Attributes to Select
        /// </summary>
        private void gvExpand_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0) // Add To Selection Attributes
            {
                #region Add To Selection Attributes Processing
                bool isChecked = (Boolean)gvExpand[0, e.RowIndex].FormattedValue;

                var displayName = (string)gvExpand[1, e.RowIndex].FormattedValue.ToString();
                var schemaName = (string)gvExpand[2, e.RowIndex].FormattedValue.ToString();

                var row = new DataGridViewRow();

                DataGridViewTextBoxCell c1 = new DataGridViewTextBoxCell();
                c1.Value = displayName;

                DataGridViewTextBoxCell c2 = new DataGridViewTextBoxCell();
                c2.Value = schemaName;

                row.Cells.Add(c1);
                row.Cells.Add(c2);

                ExpandSelectItem esi = new ExpandSelectItem();
                esi.SchemaName = schemaName;
                esi.RelationShipSchemaName = (string)gvExpand[3, e.RowIndex].FormattedValue.ToString().Replace("(1:N) ", "").Replace("(N:N) ", "");
                esi.RelationShipDisplayName = (string)gvExpand[3, e.RowIndex].FormattedValue.ToString();
                

                if (isChecked)
                {
                    gvExpandAttributes.Rows.Add(row);

                    if (relationshipsExpandSelectingAttributesList == null) relationshipsExpandSelectingAttributesList = new List<ExpandSelectItem>();
                    relationshipsExpandSelectingAttributesList.Add(esi);
                }
                else
                {
                    gvExpandAttributes.Rows.Remove(row);
                    relationshipsExpandSelectingAttributesList.Remove(esi);
                }
                #endregion
            }
        }

        /// <summary>
        /// Clear the gvSelectingAttributes gridview, the selectingAttributesList and the gvAttributes Select Column
        /// </summary>
        private void btnClearSelect_Click(object sender, EventArgs e)
        {
            gvSelectingAttributes.Rows.Clear();
            selectingAttributesList.Clear();

            foreach (DataGridViewRow row in gvAttributes.Rows.OfType<DataGridViewRow>().ToArray())
            {
                try
                {
                    (row.Cells[3] as DataGridViewCheckBoxCell).Value = false;
                }
                catch
                {

                }

            }

        }

        /// <summary>
        /// Clear the gvFilteringAttributes gridview, the filteringAttributesList and the gvAttributes Filter Column
        /// </summary>
        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            gvFilteringAttributes.Rows.Clear();
            filteringAttributesList.Clear();

            foreach (DataGridViewRow row in gvAttributes.Rows.OfType<DataGridViewRow>().ToArray())
            {
                try
                {
                    (row.Cells[4] as DataGridViewCheckBoxCell).Value = false;
                }
                catch
                {

                }

            }
        }

        /// <summary>
        /// Clear the gvOrderingAttributes gridview, the orderingAttributesList and the gvAttributes Order Column
        /// </summary>
        private void btnClearOrder_Click(object sender, EventArgs e)
        {

            gvOrderingAttributes.Rows.Clear();
            orderingAttributesList.Clear();

            foreach (DataGridViewRow row in gvAttributes.Rows.OfType<DataGridViewRow>().ToArray())
            {
                try
                {
                    (row.Cells[5] as DataGridViewCheckBoxCell).Value = false;
                }
                catch
                {

                }

            }
        }

        /// <summary>
        /// Clear the gvExpandAttributes gridview, the relationshipsExpandSelectingAttributesList and the gvExpand Select Column
        /// </summary>
        private void btnClearSelectExtandAttributes_Click(object sender, EventArgs e)
        {
            gvExpandAttributes.Rows.Clear();
            relationshipsExpandSelectingAttributesList.Clear();

            foreach (DataGridViewRow row in gvExpand.Rows.OfType<DataGridViewRow>().ToArray())
            {
                try
                {
                    (row.Cells[0] as DataGridViewCheckBoxCell).Value = false;
                }
                catch
                {

                }

            }
        }

    }
}
