using System;
using System.Collections.Generic;
using Bimser.Synergy.Entities.DataSource;
using Bimser.Synergy.Entities.DataSource.Providers;
using Bimser.CSP.FormControls.Base;
using Bimser.CSP.FormControls.Common;
using Bimser.CSP.FormControls.Controls;
using Bimser.CSP.FormControls.RuleManager;
using Bimser.CSP.FormControls.Enums;
using Bimser.Framework.Monitoring;
using Newtonsoft.Json;
using BCD_SATINALMATALEP.Entities;

namespace BCD_SATINALMATALEP.Forms {

    public partial class Form1 : Form<E_BCD_SATINALMATALEP_Form1Entity> {

        // properties
        DataGrid DataGrid1 { get; set; }
RelatedDocuments RelatedDocuments1 { get; set; }
Header Header1 { get; set; }
DocumentMetadata DocumentMetadata1 { get; set; }
DocumentMetadata DocumentMetadata2 { get; set; }
NumberBox NumberBox1 { get; set; }
UserMetadata UserMetadata1 { get; set; }
TextArea TextArea1 { get; set; }
Divider Divider1 { get; set; }
UserMetadata UserMetadata2 { get; set; }
UserMetadata UserMetadata3 { get; set; }
UserMetadata UserMetadata4 { get; set; }
Label Label1 { get; set; }
TextArea TextArea2 { get; set; }


        // constructor
        public Form1(FormHttpParameters httpParameters, ITelemetryCollectorHolder telemetryCollectorHolder = null)
 : base(httpParameters, telemetryCollectorHolder)
        {

        }

        // initialize members
        public override void InitMembers ()
        {
            
BaseComponent default_row17Component = new BaseComponent {
Id = "Row17",
Type = "Row",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Column23",
},
Properties = null
};

AddToView("default", default_row17Component);

DataGrid1 = new DataGrid {
ControlId = "1397e8b6-8d32-4c2d-d3fd-7a9ab2d5cdd8",
Name = "DataGrid1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnPropertyChanged",
MethodName = "DataGrid1_OnPropertyChanged",
Async = null
},
},
Visible = true,
ClientVisible = true,
Enabled = true,
ClientEnabled = true,
Loading = false,
CustomClassName = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Satın Alma Detayları" },{ "en-US", "DataGrid1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
}
},
ShowColon = false
},
EntityPath = "E_BCD_SATINALMATALEP_Form1_DataGrid1",
ReadOnly = false,
Columns = new DataGridColumnCollection {
new DataGridNumberBoxColumn {
Control = new NumberBox {
Visible = true,
EntityPath = "RELATIONDOCUMENTID"
},
DisableToExport = false,
Precision = null,
UseThousandSeparator = null,
Align = HorizontalAlign.Left,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Doküman Kimliği" },
{ "en-US", "Document ID" },
},
EditingEnabled = true,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 0,
Name = "RELATIONDOCUMENTID",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "100",
WordWrapEnabled = false,
IsPrimaryKey = true,
IsGeneratedColumn = true,
Visible = true,
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
AutoIncrement = false,
},
new DataGridActionButtonColumn {
ActionButtonProps = new ExecuteActionButton {
TypeName = ExecuteActionType.OpenFormArgs,
Icon = "edit",
Title = new Dictionary<string, string> {
{ "tr-TR", "Düzenle" },
{ "en-US", "Edit" },
},
Text = new Dictionary<string, string> {
{ "tr-TR", "Düzenle" },
{ "en-US", "Edit" },
},
Args = new OpenFormArgs {
DocumentId = "[RELATIONDOCUMENTID]",
Editable = false,
Size = 1,
Parameters = new List<ExecutionArgsParameterItem> {
},
},
Name = "OPENRELATIONDOCUMENT",
Visible = true,
},
DisableToExport = false,
Precision = null,
UseThousandSeparator = null,
Align = HorizontalAlign.Left,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Düzenle" },
{ "en-US", "Edit" },
},
EditingEnabled = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 0,
Name = "OPENRELATIONDOCUMENT",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "100",
WordWrapEnabled = false,
IsPrimaryKey = false,
IsGeneratedColumn = true,
Visible = true,
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
AutoIncrement = false,
},
new DataGridComboBoxColumn {
Control = new ComboBox {
Visible = true,
EntityPath = "",
Items = new ListItemCollection {
new ListItem {
Value = "1",
Key = "1",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Kahve" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
},
new ListItem {
Value = "2",
Key = "2",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Gıda" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
},
new ListItem {
Value = "3",
Key = "3",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Çay" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
},
new ListItem {
Value = "4",
Key = "4",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Bardak" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
},
},
DataSource = new DataSource {
Name = "",
ValueMember = "",
DisplayMember = new List<string>{
},
DisplayFormat = "",
Culture = "",
CultureMember = "",
MultiLanguagePath = "",
RunAtServer = false,
Parameters = new List<DataSourceParameter>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
ConnectionType = null,
},
DataSourceType = DataSourceType.Static,
},
DisableToExport = false,
Precision = 0,
UseThousandSeparator = false,
Align = HorizontalAlign.Left,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Malzeme" },
},
EditingEnabled = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 0,
Name = "ComboBox1",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "100",
WordWrapEnabled = false,
IsPrimaryKey = false,
IsGeneratedColumn = true,
Visible = true,
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
AutoIncrement = false,
},
new DataGridNumberBoxColumn {
Control = new NumberBox {
Visible = true,
EntityPath = ""
},
DisableToExport = false,
Precision = 0,
UseThousandSeparator = false,
Align = HorizontalAlign.Left,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Birim" },
},
EditingEnabled = true,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 0,
Name = "NumberBox1",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "100",
WordWrapEnabled = false,
IsPrimaryKey = false,
IsGeneratedColumn = true,
Visible = true,
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
AutoIncrement = false,
},
new DataGridNumberBoxColumn {
Control = new NumberBox {
Visible = true,
EntityPath = ""
},
DisableToExport = false,
Precision = 2,
UseThousandSeparator = true,
Align = HorizontalAlign.Left,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Birim Fiyat" },
},
EditingEnabled = true,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 0,
Name = "NumberBox2",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "100",
WordWrapEnabled = false,
IsPrimaryKey = false,
IsGeneratedColumn = true,
Visible = true,
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
AutoIncrement = false,
},
new DataGridNumberBoxColumn {
Control = new NumberBox {
Visible = true,
EntityPath = ""
},
DisableToExport = false,
Precision = 2,
UseThousandSeparator = true,
Align = HorizontalAlign.Left,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Toplam Tutar" },
},
EditingEnabled = true,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 0,
Name = "NumberBox3",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
new DataGridColumnSummary {
Type = DataGridSummaryType.Sum,
Suffix = "",
},
},
Width = "100",
WordWrapEnabled = false,
IsPrimaryKey = false,
IsGeneratedColumn = true,
Visible = true,
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
AutoIncrement = false,
},
},
Rows = new DataGridRowCollection {

},
DataSource = new DataSource {
Name = "",
ValueMember = "",
DisplayMember = new List<string>{
},
DisplayFormat = "",
Culture = "",
CultureMember = "",
MultiLanguagePath = "",
RunAtServer = false,
Parameters = new List<DataSourceParameter>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
ConnectionType = null,
},
ColumnSettings = new DataGridColumnOptions {
Orderable = false,
Resizeable = false,
ShowColumnChooser = false,
},
DetailRow = new DataGridDetailRowOptions {
Enabled = false,
},
Editing = new DataGridEditingOptions {
Enabled = false,
ShowAddCommand = false,
ShowEditCommand = false,
ShowDeleteCommand = false,
Mode = DataGridEditingModeType.Row,
},
Filtering = new DataGridFilteringOptions {
Enabled = false,
ShowOperationChooser = false,
},
Grouping = new DataGridGroupingOptions {
Enabled = false,
},
Paging = new DataGridPagingOptions {
Enabled = true,
CurrentPage = 1,
PageSize = 10,
PagingSizes = new List<int> {
10,
20,
30,
40,
},
},
Searching = new DataGridSearchingOptions {
Enabled = false,
},
Selection = new DataGridSelectionOptions {
Enabled = false,
Mode = DataGridSelectionMode.Single,
HighlightRow = true,
SelectByRowClick = true,
ShowSelectAll = false,
Type = DataGridSelectionType.Rowselect,
},
Sorting = new DataGridSortingOptions {
Enabled = false,
AllSortingColumns = true,
Mode = DataGridSortingMode.None,
},
TreeView = new DataGridTreeViewOptions {
Enabled = false,
Id = "",
ParentId = "",
},
AlternateColor = new DataGridAlternateColorOptions {
Enabled = true,
Color = "rgba(33, 150, 243, 0.05)",
},
ToolbarActionButtons = new List<ExecuteActionButton> {
new ExecuteActionButton {
TypeName = ExecuteActionType.CreateFormArgs,
Icon = "add",
Title = new Dictionary<string, string> {
{ "tr-TR", "Ekle" },
{ "en-US", "Add" },
},
Text = new Dictionary<string, string> {
{ "tr-TR", "Ekle" },
{ "en-US", "Add" },
},
Args = new CreateFormArgs {
ProjectName = "BCD_SATINALMATALEP",
FormName = "TalepForm",
Size = 1,
Parameters = new List<ExecutionArgsParameterItem> {
},
},
Name = "CREATERELATIONDOCUMENT",
Visible = true,
},
},
FillForm = null,
Height = null,
ExportToExcel = false,
GridBorder = true,
ColumnVerticalBorder = true,
VirtualScrolling = false,
GridLines = DataGridLineType.Horizontal,
DataSourceType = DataSourceType.Relation,
};

Controls.Add(DataGrid1);

BaseComponent default_datagrid1Component = new BaseComponent {
Id = "DataGrid1",
Type = "DataGrid",
ParentId = "Column18",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = DataGrid1
};

AddToView("default", default_datagrid1Component);

BaseComponent default_column7Component = new BaseComponent {
Id = "Column7",
Type = "Column",
ParentId = "Row5",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Label1",
},
Properties = null
};

AddToView("default", default_column7Component);

BaseComponent default_column9Component = new BaseComponent {
Id = "Column9",
Type = "Column",
ParentId = "Row7",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"UserMetadata1",
},
Properties = null
};

AddToView("default", default_column9Component);

RelatedDocuments1 = new RelatedDocuments {
ControlId = "146911ee-02c8-82bf-acae-6b745d045be6",
Name = "RelatedDocuments1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
ClientEnabled = true,
Loading = false,
CustomClassName = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Ekli Dosyalar" },{ "en-US", "RelatedDocuments1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
}
},
ShowColon = false
},
EntityPath = "RD.RelatedDocuments1",
ReadOnly = false,
Categories = new List<RelatedDocumentCategory> {
new RelatedDocumentCategory {
Id = 0,
CategoryId = "50470143-1624-5436-9bcf-adbbc0774e9b",
Name = new Dictionary<string, string> {
{ "tr-TR", "Varsayılan" },
},
Description = new Dictionary<string, string> {
{ "tr-TR", "Varsayılan" },
},
MinFilesCount = 1,
MaxFilesCount = 2,
MaxFileSize = null,
AllowedFileExtensions = new List<string> {
"PDF",
"DOC",
"DOCX",
"XLS",
"XLSX",
},
Enabled = true,
Path = "kozen/BCD_SATINALMATALEP/Ekler",
TargetId = ""
},
},
Files = new List<RelatedDocumentFile> {
},
AddingMode = RelatedDocumentsAddingMode.All,
ViewType = RelatedDocumentsViewType.Card,
AddNewEnabled = true,
DeleteEnabled = true,
Viewable = true,
CreateEnabled = false,
Path = "kozen/BCD_SATINALMATALEP/Ekler",
ShowCategoryDescription = false,
ShowFileDescription = true,
FileDescriptionIsRequired = false,
ShowContentForImageFiles = false,
ShowCreateDate = true,
ShowCreator = false,
ShowFileExtension = true,
ShowPath = true,
TargetId = "42965",
};

Controls.Add(RelatedDocuments1);

BaseComponent default_relateddocuments1Component = new BaseComponent {
Id = "RelatedDocuments1",
Type = "RelatedDocuments",
ParentId = "Column23",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = RelatedDocuments1
};

AddToView("default", default_relateddocuments1Component);

Header1 = new Header {
ControlId = "6d8cdc3c-084e-291e-9876-47fba661ac6c",
Name = "Header1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
ClientEnabled = true,
Loading = false,
CustomClassName = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Header1" },{ "en-US", "Header1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
}
},
ShowColon = false
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "18",
Color = "rgb(208, 2, 27)",
Bold = true,
Italic = false,
Underline = true,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "SATIN ALMA TALEP FORMU" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
HeadingType = "h3"
};

Controls.Add(Header1);

BaseComponent default_header1Component = new BaseComponent {
Id = "Header1",
Type = "Header",
ParentId = "Column1",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = Header1
};

AddToView("default", default_header1Component);

DocumentMetadata1 = new DocumentMetadata {
ControlId = "b8ed2231-702f-44ff-0787-fb9e581b7c5f",
Name = "DocumentMetadata1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
ClientEnabled = true,
Loading = false,
CustomClassName = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Belge Numarası" },{ "en-US", "DocumentMetadata1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
}
},
ShowColon = true
},
EntityPath = "DocumentMetadata1",
ReadOnly = false,
MetadataType = DocumentMetadataType.Id,
DateFormat = "",
SizeType = SizeType.Middle,
};

Controls.Add(DocumentMetadata1);

BaseComponent default_documentmetadata1Component = new BaseComponent {
Id = "DocumentMetadata1",
Type = "DocumentMetadata",
ParentId = "Column3",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = DocumentMetadata1
};

AddToView("default", default_documentmetadata1Component);

DocumentMetadata2 = new DocumentMetadata {
ControlId = "506af39e-5976-cfed-9efd-e32f5f762331",
Name = "DocumentMetadata2",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
ClientEnabled = true,
Loading = false,
CustomClassName = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Belge Tarihi" },{ "en-US", "DocumentMetadata2" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
}
},
ShowColon = true
},
EntityPath = "DocumentMetadata2",
ReadOnly = false,
MetadataType = DocumentMetadataType.CreateDate,
DateFormat = "DD.MM.YYYY",
SizeType = SizeType.Middle,
};

Controls.Add(DocumentMetadata2);

BaseComponent default_documentmetadata2Component = new BaseComponent {
Id = "DocumentMetadata2",
Type = "DocumentMetadata",
ParentId = "Column5",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = DocumentMetadata2
};

AddToView("default", default_documentmetadata2Component);

ProjectName = "BCD_SATINALMATALEP";
EntityPath = "";
ActiveView = "yoneticigorunum";
ReadOnly = false;
Text = new Dictionary<string, string> {
{ "tr-TR", "Form1" },
{ "en-US", "Form1" },
};
Name = "Form1";
FormType = FormType.Standard;
ServerEvents = new List<EventItem> {
};
ClientEvents = new List<EventItem> {
};
Statuses = new List<DocumentStatus> {
};
IdentityFormat = "<u>";
IdentityFormatId = 0;
PrintingEnabled = false;
PrintView = "default";
CopyPasteEnabled = false;
VersioningEnabled = false;
Style = new Style {
Padding = "",
BackgroundColor = "rgba(255, 255, 255, 0)",
BackgroundImage = "",
Height = null
};
PublicFields = new List<FormPublicField> {
new FormPublicField {
Field = "FORMCAPTION",
Caption = "Form Caption",
Visible = true,
DisplayFormat = "",
},
new FormPublicField {
Field = "DOCUMENTID",
Caption = "Document Id",
Visible = true,
DisplayFormat = "",
},
new FormPublicField {
Field = "STATUSTEXT",
Caption = "Status",
Visible = true,
DisplayFormat = "",
},
new FormPublicField {
Field = "CREATOR",
Caption = "Creator",
Visible = true,
DisplayFormat = "",
},
new FormPublicField {
Field = "CREATEDATE",
Caption = "Create Date",
Visible = true,
DisplayFormat = "",
},
new FormPublicField {
Field = "STATUS",
Caption = "Status Id",
Visible = false,
DisplayFormat = "",
},
new FormPublicField {
Field = "ID",
Caption = "Global Id",
Visible = false,
DisplayFormat = "",
},
};
ToolbarButtons = new List<ToolbarButton> {
new ToolbarButton {
Key = "toolbarSaveButton",
Name = "Kaydet",
Icon = "save",
Enabled = true,
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Kaydet" },{ "en-US", "Save" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = 27
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
}
},
ShowColon = false
},
},
};
Variables = new Dictionary<string, object> {
};
Rules = new Dictionary<string, Rule> {
{
"FormRequiredFields",
new Rule {
Id = "FormRequiredFields",
Name = "FormRequiredFields",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "FormRequiredFields_Statement_yoneticigorunum_TextArea2",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_yoneticigorunum_TextArea2",
Name = "TextArea2_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Yönetici Açıklaması: Gerekli alan"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_yoneticigorunum_TextArea2",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_yoneticigorunum_TextArea2_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "TextArea2",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_yoneticigorunum_TextArea2",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "Form1",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "yoneticigorunum"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_yoneticigorunum_TextArea2",
Name = "TextArea2_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Yönetici Açıklaması: Gerekli alan"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
},
},
TriggerEvents = new List<string> {
"Form1.client.OnBeforeSave",
"Form1.server.OnBeforeSave",
}
}
},
};
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Form1" },{ "en-US", "Form1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = 27
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
}
},
ShowColon = false
};

Controls.Add(this);

BaseComponent default_form1Component = new BaseComponent {
Id = "Form1",
Type = "Form",
ParentId = "",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
"Row1",
"Row3",
"Row5",
"Row7",
"Row9",
"Row11",
"Row12",
"Row13",
"Row15",
"Row17",
},
Properties = this
};

AddToView("default", default_form1Component);

NumberBox1 = new NumberBox {
ControlId = "cfeb89b6-dd2f-0b48-62fc-2ee08f4af661",
Name = "NumberBox1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
ClientEnabled = true,
Loading = false,
CustomClassName = "",
Style = new Style {
Padding = "",
BackgroundColor = "rgba(155, 155, 155, 0.8)",
BackgroundImage = "",
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Toplam Tutar" },{ "en-US", "NumberBox1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
}
},
ShowColon = true
},
EntityPath = "NumberBox1",
ReadOnly = true,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Min = null,
Max = null,
Step = 1,
Precision = 2,
UseThousandSeparator = true,
SizeType = SizeType.Middle,
};

Controls.Add(NumberBox1);

BaseComponent default_numberbox1Component = new BaseComponent {
Id = "NumberBox1",
Type = "NumberBox",
ParentId = "Column19",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = NumberBox1
};

AddToView("default", default_numberbox1Component);

BaseComponent default_column21Component = new BaseComponent {
Id = "Column21",
Type = "Column",
ParentId = "Row15",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"TextArea1",
},
Properties = null
};

AddToView("default", default_column21Component);

BaseComponent default_column11Component = new BaseComponent {
Id = "Column11",
Type = "Column",
ParentId = "Row7",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"UserMetadata2",
},
Properties = null
};

AddToView("default", default_column11Component);

BaseComponent default_column23Component = new BaseComponent {
Id = "Column23",
Type = "Column",
ParentId = "Row17",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"RelatedDocuments1",
},
Properties = null
};

AddToView("default", default_column23Component);

BaseComponent default_row1Component = new BaseComponent {
Id = "Row1",
Type = "Row",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Column1",
},
Properties = null
};

AddToView("default", default_row1Component);

UserMetadata1 = new UserMetadata {
ControlId = "0da9e567-8b4c-824b-76b3-d7e0dec56a46",
Name = "UserMetadata1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
ClientEnabled = true,
Loading = false,
CustomClassName = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Ad Soyad" },{ "en-US", "UserMetadata1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
}
},
ShowColon = true
},
EntityPath = "UserMetadata1",
ReadOnly = false,
MetadataType = UserMetadataType.NameAndSurname,
CustomMetadataName = "",
SizeType = SizeType.Middle,
};

Controls.Add(UserMetadata1);

BaseComponent default_usermetadata1Component = new BaseComponent {
Id = "UserMetadata1",
Type = "UserMetadata",
ParentId = "Column9",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = UserMetadata1
};

AddToView("default", default_usermetadata1Component);

TextArea1 = new TextArea {
ControlId = "ed736a2a-124c-af8f-e05e-823ed261de40",
Name = "TextArea1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
ClientEnabled = true,
Loading = false,
CustomClassName = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Açıklama" },{ "en-US", "TextArea1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
}
},
ShowColon = true
},
EntityPath = "ML.TextArea1",
ReadOnly = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
MaxLength = 50,
EnableMultiLanguageText = false,
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Rows = 4
};

Controls.Add(TextArea1);

BaseComponent default_textarea1Component = new BaseComponent {
Id = "TextArea1",
Type = "TextArea",
ParentId = "Column21",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = TextArea1
};

AddToView("default", default_textarea1Component);

BaseComponent default_column13Component = new BaseComponent {
Id = "Column13",
Type = "Column",
ParentId = "Row9",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"UserMetadata3",
},
Properties = null
};

AddToView("default", default_column13Component);

Divider1 = new Divider {
ControlId = "df5eca87-cf59-f261-7f27-aede785b4190",
Name = "Divider1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
ClientEnabled = true,
Loading = false,
CustomClassName = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Divider1" },{ "en-US", "Divider1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = 27
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
}
},
ShowColon = false
},
};

Controls.Add(Divider1);

BaseComponent default_divider1Component = new BaseComponent {
Id = "Divider1",
Type = "Divider",
ParentId = "Column17",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = Divider1
};

AddToView("default", default_divider1Component);

UserMetadata2 = new UserMetadata {
ControlId = "3e572957-a29e-f9b1-226c-617de9f49cd2",
Name = "UserMetadata2",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
ClientEnabled = true,
Loading = false,
CustomClassName = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Pozisyon" },{ "en-US", "UserMetadata2" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
}
},
ShowColon = true
},
EntityPath = "ML.UserMetadata2",
ReadOnly = false,
MetadataType = UserMetadataType.Position,
CustomMetadataName = "",
SizeType = SizeType.Middle,
};

Controls.Add(UserMetadata2);

BaseComponent default_usermetadata2Component = new BaseComponent {
Id = "UserMetadata2",
Type = "UserMetadata",
ParentId = "Column11",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = UserMetadata2
};

AddToView("default", default_usermetadata2Component);

BaseComponent default_row3Component = new BaseComponent {
Id = "Row3",
Type = "Row",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Column3",
"Column5",
},
Properties = null
};

AddToView("default", default_row3Component);

UserMetadata3 = new UserMetadata {
ControlId = "9e1857d1-523d-e36c-fcf5-4661864f2851",
Name = "UserMetadata3",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
ClientEnabled = true,
Loading = false,
CustomClassName = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Departman" },{ "en-US", "UserMetadata3" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
}
},
ShowColon = true
},
EntityPath = "UserMetadata3",
ReadOnly = false,
MetadataType = UserMetadataType.NameAndSurname,
CustomMetadataName = "",
SizeType = SizeType.Middle,
};

Controls.Add(UserMetadata3);

BaseComponent default_usermetadata3Component = new BaseComponent {
Id = "UserMetadata3",
Type = "UserMetadata",
ParentId = "Column13",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = UserMetadata3
};

AddToView("default", default_usermetadata3Component);

BaseComponent default_column15Component = new BaseComponent {
Id = "Column15",
Type = "Column",
ParentId = "Row9",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"UserMetadata4",
},
Properties = null
};

AddToView("default", default_column15Component);

BaseComponent default_row11Component = new BaseComponent {
Id = "Row11",
Type = "Row",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Column17",
},
Properties = null
};

AddToView("default", default_row11Component);

UserMetadata4 = new UserMetadata {
ControlId = "863691f3-cfa4-d1db-8f53-498d59d0ee32",
Name = "UserMetadata4",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
ClientEnabled = true,
Loading = false,
CustomClassName = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "E-posta" },{ "en-US", "UserMetadata4" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
}
},
ShowColon = true
},
EntityPath = "UserMetadata4",
ReadOnly = false,
MetadataType = UserMetadataType.EmailAddress,
CustomMetadataName = "",
SizeType = SizeType.Middle,
};

Controls.Add(UserMetadata4);

BaseComponent default_usermetadata4Component = new BaseComponent {
Id = "UserMetadata4",
Type = "UserMetadata",
ParentId = "Column15",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = UserMetadata4
};

AddToView("default", default_usermetadata4Component);

BaseComponent default_row12Component = new BaseComponent {
Id = "Row12",
Type = "Row",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Column18",
},
Properties = null
};

AddToView("default", default_row12Component);

BaseComponent default_row5Component = new BaseComponent {
Id = "Row5",
Type = "Row",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Column7",
},
Properties = null
};

AddToView("default", default_row5Component);

BaseComponent default_column1Component = new BaseComponent {
Id = "Column1",
Type = "Column",
ParentId = "Row1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Header1",
},
Properties = null
};

AddToView("default", default_column1Component);

BaseComponent default_column17Component = new BaseComponent {
Id = "Column17",
Type = "Column",
ParentId = "Row11",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Divider1",
},
Properties = null
};

AddToView("default", default_column17Component);

BaseComponent default_row13Component = new BaseComponent {
Id = "Row13",
Type = "Row",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Column19",
},
Properties = null
};

AddToView("default", default_row13Component);

BaseComponent default_column18Component = new BaseComponent {
Id = "Column18",
Type = "Column",
ParentId = "Row12",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"DataGrid1",
},
Properties = null
};

AddToView("default", default_column18Component);

BaseComponent default_row7Component = new BaseComponent {
Id = "Row7",
Type = "Row",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Column9",
"Column11",
},
Properties = null
};

AddToView("default", default_row7Component);

BaseComponent default_column3Component = new BaseComponent {
Id = "Column3",
Type = "Column",
ParentId = "Row3",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"DocumentMetadata1",
},
Properties = null
};

AddToView("default", default_column3Component);

Label1 = new Label {
ControlId = "e7c8405d-ed31-6ba5-cb13-d9837ca336b5",
Name = "Label1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
ClientEnabled = true,
Loading = false,
CustomClassName = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Label1" },{ "en-US", "Label1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
}
},
ShowColon = false
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#4a90e2",
Bold = true,
Italic = false,
Underline = true,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Talebi Oluşturan Kişi Bilgileri" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
};

Controls.Add(Label1);

BaseComponent default_label1Component = new BaseComponent {
Id = "Label1",
Type = "Label",
ParentId = "Column7",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = Label1
};

AddToView("default", default_label1Component);

BaseComponent default_column19Component = new BaseComponent {
Id = "Column19",
Type = "Column",
ParentId = "Row13",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"NumberBox1",
},
Properties = null
};

AddToView("default", default_column19Component);

BaseComponent default_row15Component = new BaseComponent {
Id = "Row15",
Type = "Row",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Column21",
},
Properties = null
};

AddToView("default", default_row15Component);

BaseComponent default_row9Component = new BaseComponent {
Id = "Row9",
Type = "Row",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Column13",
"Column15",
},
Properties = null
};

AddToView("default", default_row9Component);

BaseComponent default_column5Component = new BaseComponent {
Id = "Column5",
Type = "Column",
ParentId = "Row3",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"DocumentMetadata2",
},
Properties = null
};

AddToView("default", default_column5Component);

BaseComponent yoneticigorunum_datagrid1Component = new BaseComponent {
Id = "DataGrid1",
Type = "DataGrid",
ParentId = "Column18_copy",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = DataGrid1
};

AddToView("yoneticigorunum", yoneticigorunum_datagrid1Component);

BaseComponent yoneticigorunum_row18Component = new BaseComponent {
Id = "Row18",
Type = "Row",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Column24",
},
Properties = null
};

AddToView("yoneticigorunum", yoneticigorunum_row18Component);

BaseComponent yoneticigorunum_relateddocuments1Component = new BaseComponent {
Id = "RelatedDocuments1",
Type = "RelatedDocuments",
ParentId = "Column23_copy",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = RelatedDocuments1
};

AddToView("yoneticigorunum", yoneticigorunum_relateddocuments1Component);

BaseComponent yoneticigorunum_header1Component = new BaseComponent {
Id = "Header1",
Type = "Header",
ParentId = "Column1_copy",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = Header1
};

AddToView("yoneticigorunum", yoneticigorunum_header1Component);

BaseComponent yoneticigorunum_documentmetadata1Component = new BaseComponent {
Id = "DocumentMetadata1",
Type = "DocumentMetadata",
ParentId = "Column3_copy",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = DocumentMetadata1
};

AddToView("yoneticigorunum", yoneticigorunum_documentmetadata1Component);

BaseComponent yoneticigorunum_documentmetadata2Component = new BaseComponent {
Id = "DocumentMetadata2",
Type = "DocumentMetadata",
ParentId = "Column5_copy",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = DocumentMetadata2
};

AddToView("yoneticigorunum", yoneticigorunum_documentmetadata2Component);

BaseComponent yoneticigorunum_form1Component = new BaseComponent {
Id = "Form1",
Type = "Form",
ParentId = "",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
"Row1_copy",
"Row3_copy",
"Row5_copy",
"Row7_copy",
"Row9_copy",
"Row11_copy",
"Row12_copy",
"Row13_copy",
"Row15_copy",
"Row17_copy",
"Row18",
},
Properties = this
};

AddToView("yoneticigorunum", yoneticigorunum_form1Component);

BaseComponent yoneticigorunum_numberbox1Component = new BaseComponent {
Id = "NumberBox1",
Type = "NumberBox",
ParentId = "Column19_copy",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = NumberBox1
};

AddToView("yoneticigorunum", yoneticigorunum_numberbox1Component);

BaseComponent yoneticigorunum_column9_copyComponent = new BaseComponent {
Id = "Column9_copy",
Type = "Column",
ParentId = "Row7_copy",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"UserMetadata1",
},
Properties = null
};

AddToView("yoneticigorunum", yoneticigorunum_column9_copyComponent);

BaseComponent yoneticigorunum_column7_copyComponent = new BaseComponent {
Id = "Column7_copy",
Type = "Column",
ParentId = "Row5_copy",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Label1",
},
Properties = null
};

AddToView("yoneticigorunum", yoneticigorunum_column7_copyComponent);

BaseComponent yoneticigorunum_row17_copyComponent = new BaseComponent {
Id = "Row17_copy",
Type = "Row",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Column23_copy",
},
Properties = null
};

AddToView("yoneticigorunum", yoneticigorunum_row17_copyComponent);

BaseComponent yoneticigorunum_column5_copyComponent = new BaseComponent {
Id = "Column5_copy",
Type = "Column",
ParentId = "Row3_copy",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"DocumentMetadata2",
},
Properties = null
};

AddToView("yoneticigorunum", yoneticigorunum_column5_copyComponent);

BaseComponent yoneticigorunum_row9_copyComponent = new BaseComponent {
Id = "Row9_copy",
Type = "Row",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Column13_copy",
"Column15_copy",
},
Properties = null
};

AddToView("yoneticigorunum", yoneticigorunum_row9_copyComponent);

BaseComponent yoneticigorunum_row15_copyComponent = new BaseComponent {
Id = "Row15_copy",
Type = "Row",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Column21_copy",
},
Properties = null
};

AddToView("yoneticigorunum", yoneticigorunum_row15_copyComponent);

BaseComponent yoneticigorunum_column19_copyComponent = new BaseComponent {
Id = "Column19_copy",
Type = "Column",
ParentId = "Row13_copy",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"NumberBox1",
},
Properties = null
};

AddToView("yoneticigorunum", yoneticigorunum_column19_copyComponent);

BaseComponent yoneticigorunum_row7_copyComponent = new BaseComponent {
Id = "Row7_copy",
Type = "Row",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Column9_copy",
"Column11_copy",
},
Properties = null
};

AddToView("yoneticigorunum", yoneticigorunum_row7_copyComponent);

BaseComponent yoneticigorunum_column18_copyComponent = new BaseComponent {
Id = "Column18_copy",
Type = "Column",
ParentId = "Row12_copy",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"DataGrid1",
},
Properties = null
};

AddToView("yoneticigorunum", yoneticigorunum_column18_copyComponent);

BaseComponent yoneticigorunum_column3_copyComponent = new BaseComponent {
Id = "Column3_copy",
Type = "Column",
ParentId = "Row3_copy",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"DocumentMetadata1",
},
Properties = null
};

AddToView("yoneticigorunum", yoneticigorunum_column3_copyComponent);

BaseComponent yoneticigorunum_usermetadata1Component = new BaseComponent {
Id = "UserMetadata1",
Type = "UserMetadata",
ParentId = "Column9_copy",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = UserMetadata1
};

AddToView("yoneticigorunum", yoneticigorunum_usermetadata1Component);

BaseComponent yoneticigorunum_textarea1Component = new BaseComponent {
Id = "TextArea1",
Type = "TextArea",
ParentId = "Column21_copy",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = TextArea1
};

AddToView("yoneticigorunum", yoneticigorunum_textarea1Component);

BaseComponent yoneticigorunum_column24Component = new BaseComponent {
Id = "Column24",
Type = "Column",
ParentId = "Row18",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"TextArea2",
},
Properties = null
};

AddToView("yoneticigorunum", yoneticigorunum_column24Component);

BaseComponent yoneticigorunum_divider1Component = new BaseComponent {
Id = "Divider1",
Type = "Divider",
ParentId = "Column17_copy",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = Divider1
};

AddToView("yoneticigorunum", yoneticigorunum_divider1Component);

BaseComponent yoneticigorunum_row13_copyComponent = new BaseComponent {
Id = "Row13_copy",
Type = "Row",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Column19_copy",
},
Properties = null
};

AddToView("yoneticigorunum", yoneticigorunum_row13_copyComponent);

BaseComponent yoneticigorunum_column17_copyComponent = new BaseComponent {
Id = "Column17_copy",
Type = "Column",
ParentId = "Row11_copy",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Divider1",
},
Properties = null
};

AddToView("yoneticigorunum", yoneticigorunum_column17_copyComponent);

BaseComponent yoneticigorunum_usermetadata2Component = new BaseComponent {
Id = "UserMetadata2",
Type = "UserMetadata",
ParentId = "Column11_copy",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = UserMetadata2
};

AddToView("yoneticigorunum", yoneticigorunum_usermetadata2Component);

TextArea2 = new TextArea {
ControlId = "6e371fd6-8641-19e6-152c-83fa464601aa",
Name = "TextArea2",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
ClientEnabled = true,
Loading = false,
CustomClassName = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Yönetici Açıklaması" },{ "en-US", "TextArea2" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
},
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
Height = null
}
},
ShowColon = false
},
EntityPath = "ML.TextArea2",
ReadOnly = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
MaxLength = 50,
EnableMultiLanguageText = false,
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Rows = 4
};

Controls.Add(TextArea2);

BaseComponent yoneticigorunum_textarea2Component = new BaseComponent {
Id = "TextArea2",
Type = "TextArea",
ParentId = "Column24",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = TextArea2
};

AddToView("yoneticigorunum", yoneticigorunum_textarea2Component);

BaseComponent yoneticigorunum_column1_copyComponent = new BaseComponent {
Id = "Column1_copy",
Type = "Column",
ParentId = "Row1_copy",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Header1",
},
Properties = null
};

AddToView("yoneticigorunum", yoneticigorunum_column1_copyComponent);

BaseComponent yoneticigorunum_usermetadata3Component = new BaseComponent {
Id = "UserMetadata3",
Type = "UserMetadata",
ParentId = "Column13_copy",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = UserMetadata3
};

AddToView("yoneticigorunum", yoneticigorunum_usermetadata3Component);

BaseComponent yoneticigorunum_row5_copyComponent = new BaseComponent {
Id = "Row5_copy",
Type = "Row",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Column7_copy",
},
Properties = null
};

AddToView("yoneticigorunum", yoneticigorunum_row5_copyComponent);

BaseComponent yoneticigorunum_row12_copyComponent = new BaseComponent {
Id = "Row12_copy",
Type = "Row",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Column18_copy",
},
Properties = null
};

AddToView("yoneticigorunum", yoneticigorunum_row12_copyComponent);

BaseComponent yoneticigorunum_column15_copyComponent = new BaseComponent {
Id = "Column15_copy",
Type = "Column",
ParentId = "Row9_copy",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"UserMetadata4",
},
Properties = null
};

AddToView("yoneticigorunum", yoneticigorunum_column15_copyComponent);

BaseComponent yoneticigorunum_usermetadata4Component = new BaseComponent {
Id = "UserMetadata4",
Type = "UserMetadata",
ParentId = "Column15_copy",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = UserMetadata4
};

AddToView("yoneticigorunum", yoneticigorunum_usermetadata4Component);

BaseComponent yoneticigorunum_row11_copyComponent = new BaseComponent {
Id = "Row11_copy",
Type = "Row",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Column17_copy",
},
Properties = null
};

AddToView("yoneticigorunum", yoneticigorunum_row11_copyComponent);

BaseComponent yoneticigorunum_row3_copyComponent = new BaseComponent {
Id = "Row3_copy",
Type = "Row",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Column3_copy",
"Column5_copy",
},
Properties = null
};

AddToView("yoneticigorunum", yoneticigorunum_row3_copyComponent);

BaseComponent yoneticigorunum_column13_copyComponent = new BaseComponent {
Id = "Column13_copy",
Type = "Column",
ParentId = "Row9_copy",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"UserMetadata3",
},
Properties = null
};

AddToView("yoneticigorunum", yoneticigorunum_column13_copyComponent);

BaseComponent yoneticigorunum_row1_copyComponent = new BaseComponent {
Id = "Row1_copy",
Type = "Row",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Column1_copy",
},
Properties = null
};

AddToView("yoneticigorunum", yoneticigorunum_row1_copyComponent);

BaseComponent yoneticigorunum_column23_copyComponent = new BaseComponent {
Id = "Column23_copy",
Type = "Column",
ParentId = "Row17_copy",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"RelatedDocuments1",
},
Properties = null
};

AddToView("yoneticigorunum", yoneticigorunum_column23_copyComponent);

BaseComponent yoneticigorunum_label1Component = new BaseComponent {
Id = "Label1",
Type = "Label",
ParentId = "Column7_copy",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = Label1
};

AddToView("yoneticigorunum", yoneticigorunum_label1Component);

BaseComponent yoneticigorunum_column11_copyComponent = new BaseComponent {
Id = "Column11_copy",
Type = "Column",
ParentId = "Row7_copy",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"UserMetadata2",
},
Properties = null
};

AddToView("yoneticigorunum", yoneticigorunum_column11_copyComponent);

BaseComponent yoneticigorunum_column21_copyComponent = new BaseComponent {
Id = "Column21_copy",
Type = "Column",
ParentId = "Row15_copy",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"TextArea1",
},
Properties = null
};

AddToView("yoneticigorunum", yoneticigorunum_column21_copyComponent);

        }

        // initialize user events
        public override void InitUserEvents()
        {
            















        }
    }
}