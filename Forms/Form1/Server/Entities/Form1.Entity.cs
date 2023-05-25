//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:3.1.13
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bimser.CSP.FormControls.Entities;
using Bimser.Framework.Attributes.Database;
using Bimser.Framework.Domain;
using Bimser.Framework.Domain.Entities;

namespace BCD_SATINALMATALEP.Entities {
    
    
    [TableOptions(TableName="E_BCD_SATINALMATALEP_Form1")]
    public class E_BCD_SATINALMATALEP_Form1Entity : FormEntity<E_BCD_SATINALMATALEP_Form1Entity> {
        
        private Bimser.Framework.Domain.DataField<string> _DocumentMetadata1;
        
        private Bimser.Framework.Domain.DataField<string> _DocumentMetadata2;
        
        private Bimser.Framework.Domain.DataField<System.Nullable<decimal>> _NumberBox1;
        
        private Bimser.Framework.Domain.DataField<string> _UserMetadata1;
        
        private Bimser.Framework.Domain.DataField<string> _UserMetadata3;
        
        private Bimser.Framework.Domain.DataField<string> _UserMetadata4;
        
        private E_BCD_SATINALMATALEP_Form1VREntity _VersionEntity;
        
        private RDEntityCollection<E_BCD_SATINALMATALEP_Form1RDEntity, E_BCD_SATINALMATALEP_Form1RDMLEntity> _RD;
        
        private RDCEntityCollection<E_BCD_SATINALMATALEP_Form1RDCEntity, E_BCD_SATINALMATALEP_Form1RDCMLEntity> _RDC;
        
        private MLEntityCollection<E_BCD_SATINALMATALEP_Form1MLEntity> _ML;
        
        private GridEntityCollection<E_BCD_SATINALMATALEP_Form1_DataGrid1Entity, E_BCD_SATINALMATALEP_Form1_DataGrid1MLEntity, E_BCD_SATINALMATALEP_Form1_DataGrid1SLEntity, E_BCD_SATINALMATALEP_Form1_DataGrid1SLMLEntity> _E_BCD_SATINALMATALEP_Form1_DataGrid1;
        
        public E_BCD_SATINALMATALEP_Form1Entity() {
            this.ML = new MLEntityCollection<E_BCD_SATINALMATALEP_Form1MLEntity>();
            this.VersionEntity = new E_BCD_SATINALMATALEP_Form1VREntity();
            this.RD = new RDEntityCollection<E_BCD_SATINALMATALEP_Form1RDEntity, E_BCD_SATINALMATALEP_Form1RDMLEntity>();
            this.RDC = new RDCEntityCollection<E_BCD_SATINALMATALEP_Form1RDCEntity, E_BCD_SATINALMATALEP_Form1RDCMLEntity>();
            this.E_BCD_SATINALMATALEP_Form1_DataGrid1 = new GridEntityCollection<E_BCD_SATINALMATALEP_Form1_DataGrid1Entity, E_BCD_SATINALMATALEP_Form1_DataGrid1MLEntity, E_BCD_SATINALMATALEP_Form1_DataGrid1SLEntity, E_BCD_SATINALMATALEP_Form1_DataGrid1SLMLEntity>();
            this.E_BCD_SATINALMATALEP_Form1_DataGrid1.MLEntityEnabled = false;
            this.E_BCD_SATINALMATALEP_Form1_DataGrid1.SLEntityEnabled = false;
        }
        
        [ColumnOptionsAttribute(Name="DocumentMetadata1", Mandatory=false, Size=100)]
        public Bimser.Framework.Domain.DataField<string> DocumentMetadata1 {
            get {
                return this._DocumentMetadata1;
            }
            set {
                this._DocumentMetadata1 = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="DocumentMetadata2", Mandatory=false, Size=100)]
        public Bimser.Framework.Domain.DataField<string> DocumentMetadata2 {
            get {
                return this._DocumentMetadata2;
            }
            set {
                this._DocumentMetadata2 = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="NumberBox1", Mandatory=false)]
        public Bimser.Framework.Domain.DataField<System.Nullable<decimal>> NumberBox1 {
            get {
                return this._NumberBox1;
            }
            set {
                this._NumberBox1 = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="UserMetadata1", Mandatory=false, Size=100)]
        public Bimser.Framework.Domain.DataField<string> UserMetadata1 {
            get {
                return this._UserMetadata1;
            }
            set {
                this._UserMetadata1 = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="UserMetadata3", Mandatory=false, Size=100)]
        public Bimser.Framework.Domain.DataField<string> UserMetadata3 {
            get {
                return this._UserMetadata3;
            }
            set {
                this._UserMetadata3 = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="UserMetadata4", Mandatory=false, Size=100)]
        public Bimser.Framework.Domain.DataField<string> UserMetadata4 {
            get {
                return this._UserMetadata4;
            }
            set {
                this._UserMetadata4 = value;
            }
        }
        
        public E_BCD_SATINALMATALEP_Form1VREntity VersionEntity {
            get {
                return this._VersionEntity;
            }
            set {
                this._VersionEntity = value;
            }
        }
        
        public RDEntityCollection<E_BCD_SATINALMATALEP_Form1RDEntity, E_BCD_SATINALMATALEP_Form1RDMLEntity> RD {
            get {
                return this._RD;
            }
            set {
                this._RD = value;
            }
        }
        
        public RDCEntityCollection<E_BCD_SATINALMATALEP_Form1RDCEntity, E_BCD_SATINALMATALEP_Form1RDCMLEntity> RDC {
            get {
                return this._RDC;
            }
            set {
                this._RDC = value;
            }
        }
        
        public MLEntityCollection<E_BCD_SATINALMATALEP_Form1MLEntity> ML {
            get {
                return this._ML;
            }
            set {
                this._ML = value;
            }
        }
        
        public GridEntityCollection<E_BCD_SATINALMATALEP_Form1_DataGrid1Entity, E_BCD_SATINALMATALEP_Form1_DataGrid1MLEntity, E_BCD_SATINALMATALEP_Form1_DataGrid1SLEntity, E_BCD_SATINALMATALEP_Form1_DataGrid1SLMLEntity> E_BCD_SATINALMATALEP_Form1_DataGrid1 {
            get {
                return this._E_BCD_SATINALMATALEP_Form1_DataGrid1;
            }
            set {
                this._E_BCD_SATINALMATALEP_Form1_DataGrid1 = value;
            }
        }
    }
    
    [TableOptions(TableName="E_BCD_SATINALMATALEP_Form1ML")]
    public class E_BCD_SATINALMATALEP_Form1MLEntity : MLEntity<E_BCD_SATINALMATALEP_Form1MLEntity> {
        
        private Bimser.Framework.Domain.DataField<string> _TextArea1;
        
        private Bimser.Framework.Domain.DataField<string> _UserMetadata2;
        
        private Bimser.Framework.Domain.DataField<string> _TextArea2;
        
        [ColumnOptionsAttribute(Name="TextArea1", Mandatory=false, Size=50)]
        public Bimser.Framework.Domain.DataField<string> TextArea1 {
            get {
                return this._TextArea1;
            }
            set {
                this._TextArea1 = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="UserMetadata2", Mandatory=false, Size=100)]
        public Bimser.Framework.Domain.DataField<string> UserMetadata2 {
            get {
                return this._UserMetadata2;
            }
            set {
                this._UserMetadata2 = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="TextArea2", Mandatory=false, Size=50)]
        public Bimser.Framework.Domain.DataField<string> TextArea2 {
            get {
                return this._TextArea2;
            }
            set {
                this._TextArea2 = value;
            }
        }
    }
    
    [TableOptions(TableName="E_BCD_SATINALMATALEP_Form1_DataGrid1")]
    public class E_BCD_SATINALMATALEP_Form1_DataGrid1Entity : GridEntity<E_BCD_SATINALMATALEP_Form1_DataGrid1Entity, E_BCD_SATINALMATALEP_Form1_DataGrid1MLEntity, E_BCD_SATINALMATALEP_Form1_DataGrid1SLEntity, E_BCD_SATINALMATALEP_Form1_DataGrid1SLMLEntity> {
        
        private Bimser.Framework.Domain.DataField<System.Nullable<decimal>> _RELATIONDOCUMENTID;
        
        public E_BCD_SATINALMATALEP_Form1_DataGrid1Entity() {
        }
        
        [ColumnOptionsAttribute(Name="RELATIONDOCUMENTID", Mandatory=false)]
        public Bimser.Framework.Domain.DataField<System.Nullable<decimal>> RELATIONDOCUMENTID {
            get {
                return this._RELATIONDOCUMENTID;
            }
            set {
                this._RELATIONDOCUMENTID = value;
            }
        }
    }
    
    [TableOptions(TableName="E_BCD_SATINALMATALEP_Form1_DataGrid1ML")]
    public class E_BCD_SATINALMATALEP_Form1_DataGrid1MLEntity : GridMLEntity<E_BCD_SATINALMATALEP_Form1_DataGrid1MLEntity> {
    }
    
    [TableOptions(TableName="E_BCD_SATINALMATALEP_Form1_DataGrid1SL")]
    public class E_BCD_SATINALMATALEP_Form1_DataGrid1SLEntity : GridSLEntity<E_BCD_SATINALMATALEP_Form1_DataGrid1SLEntity, E_BCD_SATINALMATALEP_Form1_DataGrid1SLMLEntity> {
    }
    
    [TableOptions(TableName="E_BCD_SATINALMATALEP_Form1_DataGrid1SLML")]
    public class E_BCD_SATINALMATALEP_Form1_DataGrid1SLMLEntity : GridSLMLEntity<E_BCD_SATINALMATALEP_Form1_DataGrid1SLMLEntity> {
    }
    
    [TableOptions(TableName="E_BCD_SATINALMATALEP_Form1VR")]
    public class E_BCD_SATINALMATALEP_Form1VREntity : VersionEntity<E_BCD_SATINALMATALEP_Form1VREntity> {
    }
    
    [TableOptions(TableName="E_BCD_SATINALMATALEP_Form1RDC")]
    public class E_BCD_SATINALMATALEP_Form1RDCEntity : RDCEntity<E_BCD_SATINALMATALEP_Form1RDCEntity, E_BCD_SATINALMATALEP_Form1RDCMLEntity> {
    }
    
    [TableOptions(TableName="E_BCD_SATINALMATALEP_Form1RDCML")]
    public class E_BCD_SATINALMATALEP_Form1RDCMLEntity : RDCMLEntity<E_BCD_SATINALMATALEP_Form1RDCMLEntity> {
    }
    
    [TableOptions(TableName="E_BCD_SATINALMATALEP_Form1RD")]
    public class E_BCD_SATINALMATALEP_Form1RDEntity : RDEntity<E_BCD_SATINALMATALEP_Form1RDEntity, E_BCD_SATINALMATALEP_Form1RDMLEntity> {
    }
    
    [TableOptions(TableName="E_BCD_SATINALMATALEP_Form1RDML")]
    public class E_BCD_SATINALMATALEP_Form1RDMLEntity : RDMLEntity<E_BCD_SATINALMATALEP_Form1RDMLEntity> {
    }
}



