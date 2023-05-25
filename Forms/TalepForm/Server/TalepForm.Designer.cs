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

    public partial class TalepForm : Form<E_BCD_SATINALMATALEP_TalepFormEntity> {

        // properties
        Header Header1 { get; set; }
NumberBox NumberBox1 { get; set; }
NumberBox NumberBox2 { get; set; }
NumberBox NumberBox3 { get; set; }
ComboBox ComboBox1 { get; set; }


        // constructor
        public TalepForm(FormHttpParameters httpParameters, ITelemetryCollectorHolder telemetryCollectorHolder = null)
 : base(httpParameters, telemetryCollectorHolder)
        {

        }

        // initialize members
        public override void InitMembers ()
        {
            
BaseComponent default_column7Component = new BaseComponent {
Id = "Column7",
Type = "Column",
ParentId = "Row7",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"NumberBox2",
},
Properties = null
};

AddToView("default", default_column7Component);

BaseComponent default_column9Component = new BaseComponent {
Id = "Column9",
Type = "Column",
ParentId = "Row9",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"NumberBox3",
},
Properties = null
};

AddToView("default", default_column9Component);

Header1 = new Header {
ControlId = "0bd68a1f-0dab-ba44-077d-b2023ba17862",
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
Color = "rgb(255, 14, 14)",
Bold = true,
Italic = false,
Underline = true,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Satın Alma Talep Detayı" },}){
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

ProjectName = "BCD_SATINALMATALEP";
EntityPath = "";
ActiveView = "default";
ReadOnly = false;
Text = new Dictionary<string, string> {
{ "tr-TR", "TalepForm" },
{ "en-US", "TalepForm" },
};
Name = "TalepForm";
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
Id = "FormRequiredFields_Statement_default_ComboBox1",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_ComboBox1",
Name = "ComboBox1_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Malzeme: Gerekli alan"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_ComboBox1",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_ComboBox1_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "ComboBox1",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_ComboBox1",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "TalepForm",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_default_NumberBox1",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_NumberBox1",
Name = "NumberBox1_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Birim: Gerekli alan"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_NumberBox1",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_NumberBox1_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "NumberBox1",
PropertyName = "value",
Type = FieldValueType.Number,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_NumberBox1",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "TalepForm",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_default_NumberBox2",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_NumberBox2",
Name = "NumberBox2_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Birim Fiyat: Gerekli alan"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_NumberBox2",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_NumberBox2_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "NumberBox2",
PropertyName = "value",
Type = FieldValueType.Number,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_NumberBox2",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "TalepForm",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_ComboBox1",
Name = "ComboBox1_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Malzeme: Gerekli alan"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
},
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_NumberBox1",
Name = "NumberBox1_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Birim: Gerekli alan"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
},
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_NumberBox2",
Name = "NumberBox2_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Birim Fiyat: Gerekli alan"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
},
},
TriggerEvents = new List<string> {
"TalepForm.client.OnBeforeSave",
"TalepForm.server.OnBeforeSave",
}
}
},
{
"3b94d280-9ef1-6e28-77cd-7fa586e3dcdf",
new Rule {
Id = "3b94d280-9ef1-6e28-77cd-7fa586e3dcdf",
Name = "Toplam Tutar Hesaplama",
Enabled = true,
OrderNo = 1,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "7acd6e3a-117a-e68d-9949-9fe5fcac14e9",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValueAssignActionWithFormula {
Id = "7939bb10-4c15-f967-4ab5-daff2d13ce57",
Name = "Toplam Tutar Hesaplama",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithFormula,
Value = "[NumberBox1.value] * [NumberBox2.value]",
Field = new ValueAssignActionWithFormulaField {
Name = "NumberBox3",
PropertyName = "value",
Type = FieldValueType.Number,
EnumMembers = new List<string> {
}
}
},
},
ConditionGroup = new AndConditionGroup {
Id = "7480c022-d70c-e8be-bff2-fe38bef6f7ac",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "db3bcbb4-45db-d240-5305-179bf40099c5",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "NumberBox3",
PropertyName = "value",
Type = FieldValueType.Number,
},
Operation = OperationType.Null,
Value = 0
},
},
Children = new List<BaseConditionGroup> {
},
},
},
},
Actions = new List<BaseAction> {
new ValueAssignActionWithFormula {
Id = "7939bb10-4c15-f967-4ab5-daff2d13ce57",
Name = "Toplam Tutar Hesaplama",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithFormula,
Value = "[NumberBox1.value] * [NumberBox2.value]",
Field = new ValueAssignActionWithFormulaField {
Name = "NumberBox3",
PropertyName = "value",
Type = FieldValueType.Number,
EnumMembers = new List<string> {
}
}
},
},
TriggerEvents = new List<string> {
"TalepForm.client.OnBeforeSave",
"TalepForm.server.OnBeforeSave",
}
}
},
};
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "TalepForm" },{ "en-US", "TalepForm" },}){
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

BaseComponent default_talepformComponent = new BaseComponent {
Id = "TalepForm",
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
},
Properties = this
};

AddToView("default", default_talepformComponent);

NumberBox1 = new NumberBox {
ControlId = "8b2ad6c2-2c2d-46ef-809c-864f62cb6d9c",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Birim" },{ "en-US", "NumberBox1" },}){
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
ReadOnly = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Talep edilen malzeme adedi/miktarı" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Min = null,
Max = null,
Step = 1,
Precision = 0,
UseThousandSeparator = false,
SizeType = SizeType.Middle,
};

Controls.Add(NumberBox1);

BaseComponent default_numberbox1Component = new BaseComponent {
Id = "NumberBox1",
Type = "NumberBox",
ParentId = "Column5",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = NumberBox1
};

AddToView("default", default_numberbox1Component);

NumberBox2 = new NumberBox {
ControlId = "119205b9-61fa-b7c2-b47d-9388a62168e7",
Name = "NumberBox2",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Birim Fiyat" },{ "en-US", "NumberBox2" },}){
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
EntityPath = "NumberBox2",
ReadOnly = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Adet/miktar fiyatı" },}){
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

Controls.Add(NumberBox2);

BaseComponent default_numberbox2Component = new BaseComponent {
Id = "NumberBox2",
Type = "NumberBox",
ParentId = "Column7",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = NumberBox2
};

AddToView("default", default_numberbox2Component);

NumberBox3 = new NumberBox {
ControlId = "19103d73-1f20-5ef9-3d61-6276148b126d",
Name = "NumberBox3",
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
BackgroundColor = "rgba(155, 155, 155, 0.66)",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Toplam Tutar" },{ "en-US", "NumberBox3" },}){
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
EntityPath = "NumberBox3",
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

Controls.Add(NumberBox3);

BaseComponent default_numberbox3Component = new BaseComponent {
Id = "NumberBox3",
Type = "NumberBox",
ParentId = "Column9",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = NumberBox3
};

AddToView("default", default_numberbox3Component);

ComboBox1 = new ComboBox {
ControlId = "39bea175-03de-6711-879a-0d7b792d0bfa",
Name = "ComboBox1",
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
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Malzeme" },{ "en-US", "ComboBox1" },}){
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
EntityPath = "SL.ComboBox1",
ReadOnly = false,
TabIndex = 0,
Value = null,
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
ValueType = PrimitiveType.String,
DateValueFormat = "",
DecimalValuePrecision = 0,
SelectedIndex = null,
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
AllowClear = true,
ShowSearch = false,
SizeType = SizeType.Middle
};

Controls.Add(ComboBox1);
ComboBox1.Items = new ListItemCollection();

ComboBox1.Items.Add(new ListItem {
Value = "1",
Key = "1",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Kahve" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

ComboBox1.Items.Add(new ListItem {
Value = "2",
Key = "2",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Gıda" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

ComboBox1.Items.Add(new ListItem {
Value = "3",
Key = "3",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Çay" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

ComboBox1.Items.Add(new ListItem {
Value = "4",
Key = "4",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Bardak" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

BaseComponent default_combobox1Component = new BaseComponent {
Id = "ComboBox1",
Type = "ComboBox",
ParentId = "Column3",
DesignerProps = new DesignerProps {
AllowAutoClear = false,
},
Items = new List<string> {
},
Properties = ComboBox1
};

AddToView("default", default_combobox1Component);

BaseComponent default_row1Component = new BaseComponent {
Id = "Row1",
Type = "Row",
ParentId = "TalepForm",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Column1",
},
Properties = null
};

AddToView("default", default_row1Component);

BaseComponent default_row3Component = new BaseComponent {
Id = "Row3",
Type = "Row",
ParentId = "TalepForm",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Column3",
},
Properties = null
};

AddToView("default", default_row3Component);

BaseComponent default_row5Component = new BaseComponent {
Id = "Row5",
Type = "Row",
ParentId = "TalepForm",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Column5",
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

BaseComponent default_row7Component = new BaseComponent {
Id = "Row7",
Type = "Row",
ParentId = "TalepForm",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Column7",
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
"ComboBox1",
},
Properties = null
};

AddToView("default", default_column3Component);

BaseComponent default_row9Component = new BaseComponent {
Id = "Row9",
Type = "Row",
ParentId = "TalepForm",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"Column9",
},
Properties = null
};

AddToView("default", default_row9Component);

BaseComponent default_column5Component = new BaseComponent {
Id = "Column5",
Type = "Column",
ParentId = "Row5",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
},
Items = new List<string> {
"NumberBox1",
},
Properties = null
};

AddToView("default", default_column5Component);

        }

        // initialize user events
        public override void InitUserEvents()
        {
            






        }
    }
}