#pragma warning disable 1591
namespace ESHIFT {
    [global::System.Serializable()]
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
    [global::System.Xml.Serialization.XmlRootAttribute("eShiftDBDataSet1")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
    public partial class eShiftDBDataSet1 : global::System.Data.DataSet {
        private CustomerDataTable tableCustomer;
        private JobDataTable tableJob;
        private LoadDataTable tableLoad;
        private LoginDataTable tableLogin;
        private TempCusDTLDataTable tableTempCusDTL;
        private TransportUnitDataTable tableTransportUnit;
        private global::System.Data.DataRelation relationFK_Job_Customer;
        private global::System.Data.DataRelation relationFK_Load_Job;
        private global::System.Data.DataRelation relationFK_Load_Unit;
        private global::System.Data.SchemaSerializationMode _schemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public eShiftDBDataSet1() {
            this.BeginInit();
            this.InitClass();
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            base.Relations.CollectionChanged += schemaChangedHandler;
            this.EndInit();
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected eShiftDBDataSet1(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context, false) {
            if ((this.IsBinarySerialized(info, context) == true)) {
                this.InitVars(false);
                global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += schemaChangedHandler1;
                this.Relations.CollectionChanged += schemaChangedHandler1;
                return;
            }
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((this.DetermineSchemaSerializationMode(info, context) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
                if ((ds.Tables["Customer"] != null)) {
                    base.Tables.Add(new CustomerDataTable(ds.Tables["Customer"]));
                }
                if ((ds.Tables["Job"] != null)) {
                    base.Tables.Add(new JobDataTable(ds.Tables["Job"]));
                }
                if ((ds.Tables["Load"] != null)) {
                    base.Tables.Add(new LoadDataTable(ds.Tables["Load"]));
                }
                if ((ds.Tables["Login"] != null)) {
                    base.Tables.Add(new LoginDataTable(ds.Tables["Login"]));
                }
                if ((ds.Tables["TempCusDTL"] != null)) {
                    base.Tables.Add(new TempCusDTLDataTable(ds.Tables["TempCusDTL"]));
                }
                if ((ds.Tables["TransportUnit"] != null)) {
                    base.Tables.Add(new TransportUnitDataTable(ds.Tables["TransportUnit"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
            }
            this.GetSerializationData(info, context);
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public CustomerDataTable Customer {
            get {
                return this.tableCustomer;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public JobDataTable Job {
            get {
                return this.tableJob;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public LoadDataTable Load {
            get {
                return this.tableLoad;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public LoginDataTable Login {
            get {
                return this.tableLogin;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public TempCusDTLDataTable TempCusDTL {
            get {
                return this.tableTempCusDTL;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public TransportUnitDataTable TransportUnit {
            get {
                return this.tableTransportUnit;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.BrowsableAttribute(true)]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override global::System.Data.SchemaSerializationMode SchemaSerializationMode {
            get {
                return this._schemaSerializationMode;
            }
            set {
                this._schemaSerializationMode = value;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataTableCollection Tables {
            get {
                return base.Tables;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataRelationCollection Relations {
            get {
                return base.Relations;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected override void InitializeDerivedDataSet() {
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public override global::System.Data.DataSet Clone() {
            eShiftDBDataSet1 cln = ((eShiftDBDataSet1)(base.Clone()));
            cln.InitVars();
            cln.SchemaSerializationMode = this.SchemaSerializationMode;
            return cln;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected override bool ShouldSerializeTables() {
            return false;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected override void ReadXmlSerializable(global::System.Xml.XmlReader reader) {
            if ((this.DetermineSchemaSerializationMode(reader) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                this.Reset();
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXml(reader);
                if ((ds.Tables["Customer"] != null)) {
                    base.Tables.Add(new CustomerDataTable(ds.Tables["Customer"]));
                }
                if ((ds.Tables["Job"] != null)) {
                    base.Tables.Add(new JobDataTable(ds.Tables["Job"]));
                }
                if ((ds.Tables["Load"] != null)) {
                    base.Tables.Add(new LoadDataTable(ds.Tables["Load"]));
                }
                if ((ds.Tables["Login"] != null)) {
                    base.Tables.Add(new LoginDataTable(ds.Tables["Login"]));
                }
                if ((ds.Tables["TempCusDTL"] != null)) {
                    base.Tables.Add(new TempCusDTLDataTable(ds.Tables["TempCusDTL"]));
                }
                if ((ds.Tables["TransportUnit"] != null)) {
                    base.Tables.Add(new TransportUnitDataTable(ds.Tables["TransportUnit"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXml(reader);
                this.InitVars();
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected override global::System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
            this.WriteXmlSchema(new global::System.Xml.XmlTextWriter(stream, null));
            stream.Position = 0;
            return global::System.Xml.Schema.XmlSchema.Read(new global::System.Xml.XmlTextReader(stream), null);
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        internal void InitVars() {
            this.InitVars(true);
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        internal void InitVars(bool initTable) {
            this.tableCustomer = ((CustomerDataTable)(base.Tables["Customer"]));
            if ((initTable == true)) {
                if ((this.tableCustomer != null)) {
                    this.tableCustomer.InitVars();
                }
            }
            this.tableJob = ((JobDataTable)(base.Tables["Job"]));
            if ((initTable == true)) {
                if ((this.tableJob != null)) {
                    this.tableJob.InitVars();
                }
            }
            this.tableLoad = ((LoadDataTable)(base.Tables["Load"]));
            if ((initTable == true)) {
                if ((this.tableLoad != null)) {
                    this.tableLoad.InitVars();
                }
            }
            this.tableLogin = ((LoginDataTable)(base.Tables["Login"]));
            if ((initTable == true)) {
                if ((this.tableLogin != null)) {
                    this.tableLogin.InitVars();
                }
            }
            this.tableTempCusDTL = ((TempCusDTLDataTable)(base.Tables["TempCusDTL"]));
            if ((initTable == true)) {
                if ((this.tableTempCusDTL != null)) {
                    this.tableTempCusDTL.InitVars();
                }
            }
            this.tableTransportUnit = ((TransportUnitDataTable)(base.Tables["TransportUnit"]));
            if ((initTable == true)) {
                if ((this.tableTransportUnit != null)) {
                    this.tableTransportUnit.InitVars();
                }
            }
            this.relationFK_Job_Customer = this.Relations["FK_Job_Customer"];
            this.relationFK_Load_Job = this.Relations["FK_Load_Job"];
            this.relationFK_Load_Unit = this.Relations["FK_Load_Unit"];
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitClass() {
            this.DataSetName = "eShiftDBDataSet1";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/eShiftDBDataSet1.xsd";
            this.EnforceConstraints = true;
            this.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
            this.tableCustomer = new CustomerDataTable();
            base.Tables.Add(this.tableCustomer);
            this.tableJob = new JobDataTable();
            base.Tables.Add(this.tableJob);
            this.tableLoad = new LoadDataTable();
            base.Tables.Add(this.tableLoad);
            this.tableLogin = new LoginDataTable();
            base.Tables.Add(this.tableLogin);
            this.tableTempCusDTL = new TempCusDTLDataTable();
            base.Tables.Add(this.tableTempCusDTL);
            this.tableTransportUnit = new TransportUnitDataTable();
            base.Tables.Add(this.tableTransportUnit);
            this.relationFK_Job_Customer = new global::System.Data.DataRelation("FK_Job_Customer", new global::System.Data.DataColumn[] {
                        this.tableCustomer.CustomerIdColumn}, new global::System.Data.DataColumn[] {
                        this.tableJob.CustomerIdColumn}, false);
            this.Relations.Add(this.relationFK_Job_Customer);
            this.relationFK_Load_Job = new global::System.Data.DataRelation("FK_Load_Job", new global::System.Data.DataColumn[] {
                        this.tableJob.JobIdColumn}, new global::System.Data.DataColumn[] {
                        this.tableLoad.JobIdColumn}, false);
            this.Relations.Add(this.relationFK_Load_Job);
            this.relationFK_Load_Unit = new global::System.Data.DataRelation("FK_Load_Unit", new global::System.Data.DataColumn[] {
                        this.tableTransportUnit.UnitIdColumn}, new global::System.Data.DataColumn[] {
                        this.tableLoad.TransportUnitIdColumn}, false);
            this.Relations.Add(this.relationFK_Load_Unit);
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private bool ShouldSerializeCustomer() {
            return false;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private bool ShouldSerializeJob() {
            return false;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private bool ShouldSerializeLoad() {
            return false;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private bool ShouldSerializeLogin() {
            return false;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private bool ShouldSerializeTempCusDTL() {
            return false;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private bool ShouldSerializeTransportUnit() {
            return false;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void SchemaChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == global::System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
            eShiftDBDataSet1 ds = new eShiftDBDataSet1();
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            global::System.Xml.Schema.XmlSchemaAny any = new global::System.Xml.Schema.XmlSchemaAny();
            any.Namespace = ds.Namespace;
            sequence.Items.Add(any);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace)) {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length)) {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length) 
                                        && (s1.ReadByte() == s2.ReadByte())); ) {
                                ;
                            }
                            if ((s1.Position == s1.Length)) {
                                return type;
                            }
                        }
                    }
                }
                finally {
                    if ((s1 != null)) {
                        s1.Close();
                    }
                    if ((s2 != null)) {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public delegate void CustomerRowChangeEventHandler(object sender, CustomerRowChangeEvent e);
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public delegate void JobRowChangeEventHandler(object sender, JobRowChangeEvent e);
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public delegate void LoadRowChangeEventHandler(object sender, LoadRowChangeEvent e);
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public delegate void LoginRowChangeEventHandler(object sender, LoginRowChangeEvent e);
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public delegate void TempCusDTLRowChangeEventHandler(object sender, TempCusDTLRowChangeEvent e);
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public delegate void TransportUnitRowChangeEventHandler(object sender, TransportUnitRowChangeEvent e);
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class CustomerDataTable : global::System.Data.TypedTableBase<CustomerRow> {
            private global::System.Data.DataColumn columnCustomerId;
            private global::System.Data.DataColumn columnName;
            private global::System.Data.DataColumn columnCustomerIdNo;
            private global::System.Data.DataColumn columnPhone;
            private global::System.Data.DataColumn columnEmail;
            private global::System.Data.DataColumn columnAddress;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public CustomerDataTable() {
                this.TableName = "Customer";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal CustomerDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected CustomerDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn CustomerIdColumn {
                get {
                    return this.columnCustomerId;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn NameColumn {
                get {
                    return this.columnName;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn CustomerIdNoColumn {
                get {
                    return this.columnCustomerIdNo;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn PhoneColumn {
                get {
                    return this.columnPhone;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn EmailColumn {
                get {
                    return this.columnEmail;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn AddressColumn {
                get {
                    return this.columnAddress;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public CustomerRow this[int index] {
                get {
                    return ((CustomerRow)(this.Rows[index]));
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event CustomerRowChangeEventHandler CustomerRowChanging;
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event CustomerRowChangeEventHandler CustomerRowChanged;
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event CustomerRowChangeEventHandler CustomerRowDeleting;
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event CustomerRowChangeEventHandler CustomerRowDeleted;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void AddCustomerRow(CustomerRow row) {
                this.Rows.Add(row);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public CustomerRow AddCustomerRow(string Name, string CustomerIdNo, string Phone, string Email, string Address) {
                CustomerRow rowCustomerRow = ((CustomerRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Name,
                        CustomerIdNo,
                        Phone,
                        Email,
                        Address};
                rowCustomerRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowCustomerRow);
                return rowCustomerRow;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public CustomerRow FindByCustomerId(int CustomerId) {
                return ((CustomerRow)(this.Rows.Find(new object[] {
                            CustomerId})));
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                CustomerDataTable cln = ((CustomerDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new CustomerDataTable();
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal void InitVars() {
                this.columnCustomerId = base.Columns["CustomerId"];
                this.columnName = base.Columns["Name"];
                this.columnCustomerIdNo = base.Columns["CustomerIdNo"];
                this.columnPhone = base.Columns["Phone"];
                this.columnEmail = base.Columns["Email"];
                this.columnAddress = base.Columns["Address"];
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            private void InitClass() {
                this.columnCustomerId = new global::System.Data.DataColumn("CustomerId", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnCustomerId);
                this.columnName = new global::System.Data.DataColumn("Name", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnName);
                this.columnCustomerIdNo = new global::System.Data.DataColumn("CustomerIdNo", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnCustomerIdNo);
                this.columnPhone = new global::System.Data.DataColumn("Phone", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnPhone);
                this.columnEmail = new global::System.Data.DataColumn("Email", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnEmail);
                this.columnAddress = new global::System.Data.DataColumn("Address", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnAddress);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnCustomerId}, true));
                this.columnCustomerId.AutoIncrement = true;
                this.columnCustomerId.AutoIncrementSeed = -1;
                this.columnCustomerId.AutoIncrementStep = -1;
                this.columnCustomerId.AllowDBNull = false;
                this.columnCustomerId.ReadOnly = true;
                this.columnCustomerId.Unique = true;
                this.columnName.AllowDBNull = false;
                this.columnName.MaxLength = 100;
                this.columnCustomerIdNo.MaxLength = 50;
                this.columnPhone.MaxLength = 50;
                this.columnEmail.MaxLength = 100;
                this.columnAddress.MaxLength = 200;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public CustomerRow NewCustomerRow() {
                return ((CustomerRow)(this.NewRow()));
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new CustomerRow(builder);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(CustomerRow);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.CustomerRowChanged != null)) {
                    this.CustomerRowChanged(this, new CustomerRowChangeEvent(((CustomerRow)(e.Row)), e.Action));
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.CustomerRowChanging != null)) {
                    this.CustomerRowChanging(this, new CustomerRowChangeEvent(((CustomerRow)(e.Row)), e.Action));
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.CustomerRowDeleted != null)) {
                    this.CustomerRowDeleted(this, new CustomerRowChangeEvent(((CustomerRow)(e.Row)), e.Action));
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.CustomerRowDeleting != null)) {
                    this.CustomerRowDeleting(this, new CustomerRowChangeEvent(((CustomerRow)(e.Row)), e.Action));
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void RemoveCustomerRow(CustomerRow row) {
                this.Rows.Remove(row);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                eShiftDBDataSet1 ds = new eShiftDBDataSet1();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "CustomerDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class JobDataTable : global::System.Data.TypedTableBase<JobRow> {
            private global::System.Data.DataColumn columnJobId;
            private global::System.Data.DataColumn columnCustomerId;
            private global::System.Data.DataColumn columnStartLocation;
            private global::System.Data.DataColumn columnDestination;
            private global::System.Data.DataColumn columnPickupDate;
            private global::System.Data.DataColumn columnDeliveryDate;
            private global::System.Data.DataColumn columnStatus;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public JobDataTable() {
                this.TableName = "Job";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal JobDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected JobDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn JobIdColumn {
                get {
                    return this.columnJobId;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn CustomerIdColumn {
                get {
                    return this.columnCustomerId;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn StartLocationColumn {
                get {
                    return this.columnStartLocation;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn DestinationColumn {
                get {
                    return this.columnDestination;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn PickupDateColumn {
                get {
                    return this.columnPickupDate;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn DeliveryDateColumn {
                get {
                    return this.columnDeliveryDate;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn StatusColumn {
                get {
                    return this.columnStatus;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public JobRow this[int index] {
                get {
                    return ((JobRow)(this.Rows[index]));
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event JobRowChangeEventHandler JobRowChanging;
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event JobRowChangeEventHandler JobRowChanged;
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event JobRowChangeEventHandler JobRowDeleting;
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event JobRowChangeEventHandler JobRowDeleted;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void AddJobRow(JobRow row) {
                this.Rows.Add(row);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public JobRow AddJobRow(CustomerRow parentCustomerRowByFK_Job_Customer, string StartLocation, string Destination, System.DateTime PickupDate, System.DateTime DeliveryDate, string Status) {
                JobRow rowJobRow = ((JobRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        null,
                        StartLocation,
                        Destination,
                        PickupDate,
                        DeliveryDate,
                        Status};
                if ((parentCustomerRowByFK_Job_Customer != null)) {
                    columnValuesArray[1] = parentCustomerRowByFK_Job_Customer[0];
                }
                rowJobRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowJobRow);
                return rowJobRow;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public JobRow FindByJobId(int JobId) {
                return ((JobRow)(this.Rows.Find(new object[] {
                            JobId})));
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                JobDataTable cln = ((JobDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new JobDataTable();
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal void InitVars() {
                this.columnJobId = base.Columns["JobId"];
                this.columnCustomerId = base.Columns["CustomerId"];
                this.columnStartLocation = base.Columns["StartLocation"];
                this.columnDestination = base.Columns["Destination"];
                this.columnPickupDate = base.Columns["PickupDate"];
                this.columnDeliveryDate = base.Columns["DeliveryDate"];
                this.columnStatus = base.Columns["Status"];
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            private void InitClass() {
                this.columnJobId = new global::System.Data.DataColumn("JobId", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnJobId);
                this.columnCustomerId = new global::System.Data.DataColumn("CustomerId", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnCustomerId);
                this.columnStartLocation = new global::System.Data.DataColumn("StartLocation", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnStartLocation);
                this.columnDestination = new global::System.Data.DataColumn("Destination", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnDestination);
                this.columnPickupDate = new global::System.Data.DataColumn("PickupDate", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnPickupDate);
                this.columnDeliveryDate = new global::System.Data.DataColumn("DeliveryDate", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnDeliveryDate);
                this.columnStatus = new global::System.Data.DataColumn("Status", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnStatus);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnJobId}, true));
                this.columnJobId.AutoIncrement = true;
                this.columnJobId.AutoIncrementSeed = -1;
                this.columnJobId.AutoIncrementStep = -1;
                this.columnJobId.AllowDBNull = false;
                this.columnJobId.ReadOnly = true;
                this.columnJobId.Unique = true;
                this.columnCustomerId.AllowDBNull = false;
                this.columnStartLocation.MaxLength = 100;
                this.columnDestination.MaxLength = 100;
                this.columnStatus.MaxLength = 50;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public JobRow NewJobRow() {
                return ((JobRow)(this.NewRow()));
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new JobRow(builder);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(JobRow);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.JobRowChanged != null)) {
                    this.JobRowChanged(this, new JobRowChangeEvent(((JobRow)(e.Row)), e.Action));
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.JobRowChanging != null)) {
                    this.JobRowChanging(this, new JobRowChangeEvent(((JobRow)(e.Row)), e.Action));
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.JobRowDeleted != null)) {
                    this.JobRowDeleted(this, new JobRowChangeEvent(((JobRow)(e.Row)), e.Action));
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.JobRowDeleting != null)) {
                    this.JobRowDeleting(this, new JobRowChangeEvent(((JobRow)(e.Row)), e.Action));
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void RemoveJobRow(JobRow row) {
                this.Rows.Remove(row);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                eShiftDBDataSet1 ds = new eShiftDBDataSet1();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "JobDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class LoadDataTable : global::System.Data.TypedTableBase<LoadRow> {
            private global::System.Data.DataColumn columnLoadId;
            private global::System.Data.DataColumn columnJobId;
            private global::System.Data.DataColumn columnTransportUnitId;
            private global::System.Data.DataColumn columnDescription;
            private global::System.Data.DataColumn columnWeightKg;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public LoadDataTable() {
                this.TableName = "Load";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal LoadDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected LoadDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn LoadIdColumn {
                get {
                    return this.columnLoadId;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn JobIdColumn {
                get {
                    return this.columnJobId;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn TransportUnitIdColumn {
                get {
                    return this.columnTransportUnitId;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn DescriptionColumn {
                get {
                    return this.columnDescription;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn WeightKgColumn {
                get {
                    return this.columnWeightKg;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public LoadRow this[int index] {
                get {
                    return ((LoadRow)(this.Rows[index]));
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event LoadRowChangeEventHandler LoadRowChanging;
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event LoadRowChangeEventHandler LoadRowChanged;
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event LoadRowChangeEventHandler LoadRowDeleting;
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event LoadRowChangeEventHandler LoadRowDeleted;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void AddLoadRow(LoadRow row) {
                this.Rows.Add(row);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public LoadRow AddLoadRow(JobRow parentJobRowByFK_Load_Job, TransportUnitRow parentTransportUnitRowByFK_Load_Unit, string Description, double WeightKg) {
                LoadRow rowLoadRow = ((LoadRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        null,
                        null,
                        Description,
                        WeightKg};
                if ((parentJobRowByFK_Load_Job != null)) {
                    columnValuesArray[1] = parentJobRowByFK_Load_Job[0];
                }
                if ((parentTransportUnitRowByFK_Load_Unit != null)) {
                    columnValuesArray[2] = parentTransportUnitRowByFK_Load_Unit[0];
                }
                rowLoadRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowLoadRow);
                return rowLoadRow;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public LoadRow FindByLoadId(int LoadId) {
                return ((LoadRow)(this.Rows.Find(new object[] {
                            LoadId})));
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                LoadDataTable cln = ((LoadDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new LoadDataTable();
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal void InitVars() {
                this.columnLoadId = base.Columns["LoadId"];
                this.columnJobId = base.Columns["JobId"];
                this.columnTransportUnitId = base.Columns["TransportUnitId"];
                this.columnDescription = base.Columns["Description"];
                this.columnWeightKg = base.Columns["WeightKg"];
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            private void InitClass() {
                this.columnLoadId = new global::System.Data.DataColumn("LoadId", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnLoadId);
                this.columnJobId = new global::System.Data.DataColumn("JobId", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnJobId);
                this.columnTransportUnitId = new global::System.Data.DataColumn("TransportUnitId", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnTransportUnitId);
                this.columnDescription = new global::System.Data.DataColumn("Description", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnDescription);
                this.columnWeightKg = new global::System.Data.DataColumn("WeightKg", typeof(double), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnWeightKg);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnLoadId}, true));
                this.columnLoadId.AutoIncrement = true;
                this.columnLoadId.AutoIncrementSeed = -1;
                this.columnLoadId.AutoIncrementStep = -1;
                this.columnLoadId.AllowDBNull = false;
                this.columnLoadId.ReadOnly = true;
                this.columnLoadId.Unique = true;
                this.columnJobId.AllowDBNull = false;
                this.columnDescription.MaxLength = 200;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public LoadRow NewLoadRow() {
                return ((LoadRow)(this.NewRow()));
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new LoadRow(builder);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(LoadRow);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.LoadRowChanged != null)) {
                    this.LoadRowChanged(this, new LoadRowChangeEvent(((LoadRow)(e.Row)), e.Action));
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.LoadRowChanging != null)) {
                    this.LoadRowChanging(this, new LoadRowChangeEvent(((LoadRow)(e.Row)), e.Action));
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.LoadRowDeleted != null)) {
                    this.LoadRowDeleted(this, new LoadRowChangeEvent(((LoadRow)(e.Row)), e.Action));
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.LoadRowDeleting != null)) {
                    this.LoadRowDeleting(this, new LoadRowChangeEvent(((LoadRow)(e.Row)), e.Action));
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void RemoveLoadRow(LoadRow row) {
                this.Rows.Remove(row);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                eShiftDBDataSet1 ds = new eShiftDBDataSet1();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "LoadDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class LoginDataTable : global::System.Data.TypedTableBase<LoginRow> {
            private global::System.Data.DataColumn columnUserName;
            private global::System.Data.DataColumn columnPassword;
            private global::System.Data.DataColumn columnRole;
            private global::System.Data.DataColumn columnidno;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public LoginDataTable() {
                this.TableName = "Login";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal LoginDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected LoginDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn UserNameColumn {
                get {
                    return this.columnUserName;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn PasswordColumn {
                get {
                    return this.columnPassword;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn RoleColumn {
                get {
                    return this.columnRole;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn idnoColumn {
                get {
                    return this.columnidno;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public LoginRow this[int index] {
                get {
                    return ((LoginRow)(this.Rows[index]));
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event LoginRowChangeEventHandler LoginRowChanging;
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event LoginRowChangeEventHandler LoginRowChanged;
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event LoginRowChangeEventHandler LoginRowDeleting;
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event LoginRowChangeEventHandler LoginRowDeleted;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void AddLoginRow(LoginRow row) {
                this.Rows.Add(row);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public LoginRow AddLoginRow(string UserName, string Password, string Role) {
                LoginRow rowLoginRow = ((LoginRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        UserName,
                        Password,
                        Role,
                        null};
                rowLoginRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowLoginRow);
                return rowLoginRow;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public LoginRow FindByidno(int idno) {
                return ((LoginRow)(this.Rows.Find(new object[] {
                            idno})));
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                LoginDataTable cln = ((LoginDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new LoginDataTable();
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal void InitVars() {
                this.columnUserName = base.Columns["UserName"];
                this.columnPassword = base.Columns["Password"];
                this.columnRole = base.Columns["Role"];
                this.columnidno = base.Columns["idno"];
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            private void InitClass() {
                this.columnUserName = new global::System.Data.DataColumn("UserName", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnUserName);
                this.columnPassword = new global::System.Data.DataColumn("Password", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnPassword);
                this.columnRole = new global::System.Data.DataColumn("Role", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnRole);
                this.columnidno = new global::System.Data.DataColumn("idno", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnidno);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnidno}, true));
                this.columnUserName.AllowDBNull = false;
                this.columnUserName.MaxLength = 50;
                this.columnPassword.AllowDBNull = false;
                this.columnPassword.MaxLength = 50;
                this.columnRole.MaxLength = 30;
                this.columnidno.AutoIncrement = true;
                this.columnidno.AutoIncrementSeed = -1;
                this.columnidno.AutoIncrementStep = -1;
                this.columnidno.AllowDBNull = false;
                this.columnidno.ReadOnly = true;
                this.columnidno.Unique = true;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public LoginRow NewLoginRow() {
                return ((LoginRow)(this.NewRow()));
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new LoginRow(builder);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(LoginRow);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.LoginRowChanged != null)) {
                    this.LoginRowChanged(this, new LoginRowChangeEvent(((LoginRow)(e.Row)), e.Action));
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.LoginRowChanging != null)) {
                    this.LoginRowChanging(this, new LoginRowChangeEvent(((LoginRow)(e.Row)), e.Action));
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.LoginRowDeleted != null)) {
                    this.LoginRowDeleted(this, new LoginRowChangeEvent(((LoginRow)(e.Row)), e.Action));
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.LoginRowDeleting != null)) {
                    this.LoginRowDeleting(this, new LoginRowChangeEvent(((LoginRow)(e.Row)), e.Action));
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void RemoveLoginRow(LoginRow row) {
                this.Rows.Remove(row);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                eShiftDBDataSet1 ds = new eShiftDBDataSet1();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "LoginDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class TempCusDTLDataTable : global::System.Data.TypedTableBase<TempCusDTLRow> {
            private global::System.Data.DataColumn columnTemporyCus_ID;
            private global::System.Data.DataColumn columnName;
            private global::System.Data.DataColumn columnNIC;
            private global::System.Data.DataColumn columnphone;
            private global::System.Data.DataColumn columnEmail;
            private global::System.Data.DataColumn columnAddress;
            private global::System.Data.DataColumn columnItem;
            private global::System.Data.DataColumn columnStart_Location;
            private global::System.Data.DataColumn columnDestination;
            private global::System.Data.DataColumn columnDate;
            private global::System.Data.DataColumn columnStatus;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public TempCusDTLDataTable() {
                this.TableName = "TempCusDTL";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal TempCusDTLDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected TempCusDTLDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn TemporyCus_IDColumn {
                get {
                    return this.columnTemporyCus_ID;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn NameColumn {
                get {
                    return this.columnName;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn NICColumn {
                get {
                    return this.columnNIC;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn phoneColumn {
                get {
                    return this.columnphone;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn EmailColumn {
                get {
                    return this.columnEmail;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn AddressColumn {
                get {
                    return this.columnAddress;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn ItemColumn {
                get {
                    return this.columnItem;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn Start_LocationColumn {
                get {
                    return this.columnStart_Location;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn DestinationColumn {
                get {
                    return this.columnDestination;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn DateColumn {
                get {
                    return this.columnDate;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn StatusColumn {
                get {
                    return this.columnStatus;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public TempCusDTLRow this[int index] {
                get {
                    return ((TempCusDTLRow)(this.Rows[index]));
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event TempCusDTLRowChangeEventHandler TempCusDTLRowChanging;
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event TempCusDTLRowChangeEventHandler TempCusDTLRowChanged;
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event TempCusDTLRowChangeEventHandler TempCusDTLRowDeleting;
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event TempCusDTLRowChangeEventHandler TempCusDTLRowDeleted;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void AddTempCusDTLRow(TempCusDTLRow row) {
                this.Rows.Add(row);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public TempCusDTLRow AddTempCusDTLRow(string Name, string NIC, string phone, string Email, string Address, string Item, string Start_Location, string Destination, System.DateTime Date, string Status) {
                TempCusDTLRow rowTempCusDTLRow = ((TempCusDTLRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        Name,
                        NIC,
                        phone,
                        Email,
                        Address,
                        Item,
                        Start_Location,
                        Destination,
                        Date,
                        Status};
                rowTempCusDTLRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowTempCusDTLRow);
                return rowTempCusDTLRow;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public TempCusDTLRow FindByTemporyCus_ID(int TemporyCus_ID) {
                return ((TempCusDTLRow)(this.Rows.Find(new object[] {
                            TemporyCus_ID})));
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                TempCusDTLDataTable cln = ((TempCusDTLDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new TempCusDTLDataTable();
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal void InitVars() {
                this.columnTemporyCus_ID = base.Columns["TemporyCus_ID"];
                this.columnName = base.Columns["Name"];
                this.columnNIC = base.Columns["NIC"];
                this.columnphone = base.Columns["phone"];
                this.columnEmail = base.Columns["Email"];
                this.columnAddress = base.Columns["Address"];
                this.columnItem = base.Columns["Item"];
                this.columnStart_Location = base.Columns["Start_Location"];
                this.columnDestination = base.Columns["Destination"];
                this.columnDate = base.Columns["Date"];
                this.columnStatus = base.Columns["Status"];
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            private void InitClass() {
                this.columnTemporyCus_ID = new global::System.Data.DataColumn("TemporyCus_ID", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnTemporyCus_ID);
                this.columnName = new global::System.Data.DataColumn("Name", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnName);
                this.columnNIC = new global::System.Data.DataColumn("NIC", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnNIC);
                this.columnphone = new global::System.Data.DataColumn("phone", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnphone);
                this.columnEmail = new global::System.Data.DataColumn("Email", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnEmail);
                this.columnAddress = new global::System.Data.DataColumn("Address", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnAddress);
                this.columnItem = new global::System.Data.DataColumn("Item", typeof(string), null, global::System.Data.MappingType.Element);
                this.columnItem.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "Item");
                this.columnItem.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "ItemColumn");
                this.columnItem.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "columnItem");
                this.columnItem.ExtendedProperties.Add("Generator_UserColumnName", "Item");
                base.Columns.Add(this.columnItem);
                this.columnStart_Location = new global::System.Data.DataColumn("Start_Location", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnStart_Location);
                this.columnDestination = new global::System.Data.DataColumn("Destination", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnDestination);
                this.columnDate = new global::System.Data.DataColumn("Date", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnDate);
                this.columnStatus = new global::System.Data.DataColumn("Status", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnStatus);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnTemporyCus_ID}, true));
                this.columnTemporyCus_ID.AutoIncrement = true;
                this.columnTemporyCus_ID.AutoIncrementSeed = -1;
                this.columnTemporyCus_ID.AutoIncrementStep = -1;
                this.columnTemporyCus_ID.AllowDBNull = false;
                this.columnTemporyCus_ID.ReadOnly = true;
                this.columnTemporyCus_ID.Unique = true;
                this.columnName.AllowDBNull = false;
                this.columnName.MaxLength = 50;
                this.columnNIC.AllowDBNull = false;
                this.columnNIC.MaxLength = 50;
                this.columnphone.AllowDBNull = false;
                this.columnphone.MaxLength = 50;
                this.columnEmail.AllowDBNull = false;
                this.columnEmail.MaxLength = 50;
                this.columnAddress.AllowDBNull = false;
                this.columnAddress.MaxLength = 50;
                this.columnItem.AllowDBNull = false;
                this.columnItem.MaxLength = 50;
                this.columnStart_Location.AllowDBNull = false;
                this.columnStart_Location.MaxLength = 50;
                this.columnDestination.AllowDBNull = false;
                this.columnDestination.MaxLength = 50;
                this.columnDate.AllowDBNull = false;
                this.columnStatus.MaxLength = 10;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public TempCusDTLRow NewTempCusDTLRow() {
                return ((TempCusDTLRow)(this.NewRow()));
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new TempCusDTLRow(builder);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(TempCusDTLRow);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.TempCusDTLRowChanged != null)) {
                    this.TempCusDTLRowChanged(this, new TempCusDTLRowChangeEvent(((TempCusDTLRow)(e.Row)), e.Action));
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.TempCusDTLRowChanging != null)) {
                    this.TempCusDTLRowChanging(this, new TempCusDTLRowChangeEvent(((TempCusDTLRow)(e.Row)), e.Action));
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.TempCusDTLRowDeleted != null)) {
                    this.TempCusDTLRowDeleted(this, new TempCusDTLRowChangeEvent(((TempCusDTLRow)(e.Row)), e.Action));
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.TempCusDTLRowDeleting != null)) {
                    this.TempCusDTLRowDeleting(this, new TempCusDTLRowChangeEvent(((TempCusDTLRow)(e.Row)), e.Action));
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void RemoveTempCusDTLRow(TempCusDTLRow row) {
                this.Rows.Remove(row);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                eShiftDBDataSet1 ds = new eShiftDBDataSet1();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "TempCusDTLDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class TransportUnitDataTable : global::System.Data.TypedTableBase<TransportUnitRow> {
            private global::System.Data.DataColumn columnUnitId;
            private global::System.Data.DataColumn columnVehicleNumberPlate;
            private global::System.Data.DataColumn columnDriverName;
            private global::System.Data.DataColumn columnDriverPhone;
            private global::System.Data.DataColumn columnDriverIdNo;
            private global::System.Data.DataColumn columnAssistantName;
            private global::System.Data.DataColumn columnAssistantPhone;
            private global::System.Data.DataColumn columnAssistantIdNo;
            private global::System.Data.DataColumn columnContainerId;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public TransportUnitDataTable() {
                this.TableName = "TransportUnit";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal TransportUnitDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected TransportUnitDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn UnitIdColumn {
                get {
                    return this.columnUnitId;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn VehicleNumberPlateColumn {
                get {
                    return this.columnVehicleNumberPlate;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn DriverNameColumn {
                get {
                    return this.columnDriverName;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn DriverPhoneColumn {
                get {
                    return this.columnDriverPhone;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn DriverIdNoColumn {
                get {
                    return this.columnDriverIdNo;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn AssistantNameColumn {
                get {
                    return this.columnAssistantName;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn AssistantPhoneColumn {
                get {
                    return this.columnAssistantPhone;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn AssistantIdNoColumn {
                get {
                    return this.columnAssistantIdNo;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataColumn ContainerIdColumn {
                get {
                    return this.columnContainerId;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public TransportUnitRow this[int index] {
                get {
                    return ((TransportUnitRow)(this.Rows[index]));
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event TransportUnitRowChangeEventHandler TransportUnitRowChanging;
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event TransportUnitRowChangeEventHandler TransportUnitRowChanged;
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event TransportUnitRowChangeEventHandler TransportUnitRowDeleting;
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public event TransportUnitRowChangeEventHandler TransportUnitRowDeleted;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void AddTransportUnitRow(TransportUnitRow row) {
                this.Rows.Add(row);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public TransportUnitRow AddTransportUnitRow(string VehicleNumberPlate, string DriverName, string DriverPhone, string DriverIdNo, string AssistantName, string AssistantPhone, string AssistantIdNo, string ContainerId) {
                TransportUnitRow rowTransportUnitRow = ((TransportUnitRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        null,
                        VehicleNumberPlate,
                        DriverName,
                        DriverPhone,
                        DriverIdNo,
                        AssistantName,
                        AssistantPhone,
                        AssistantIdNo,
                        ContainerId};
                rowTransportUnitRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowTransportUnitRow);
                return rowTransportUnitRow;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public TransportUnitRow FindByUnitId(int UnitId) {
                return ((TransportUnitRow)(this.Rows.Find(new object[] {
                            UnitId})));
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                TransportUnitDataTable cln = ((TransportUnitDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new TransportUnitDataTable();
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal void InitVars() {
                this.columnUnitId = base.Columns["UnitId"];
                this.columnVehicleNumberPlate = base.Columns["VehicleNumberPlate"];
                this.columnDriverName = base.Columns["DriverName"];
                this.columnDriverPhone = base.Columns["DriverPhone"];
                this.columnDriverIdNo = base.Columns["DriverIdNo"];
                this.columnAssistantName = base.Columns["AssistantName"];
                this.columnAssistantPhone = base.Columns["AssistantPhone"];
                this.columnAssistantIdNo = base.Columns["AssistantIdNo"];
                this.columnContainerId = base.Columns["ContainerId"];
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            private void InitClass() {
                this.columnUnitId = new global::System.Data.DataColumn("UnitId", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnUnitId);
                this.columnVehicleNumberPlate = new global::System.Data.DataColumn("VehicleNumberPlate", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnVehicleNumberPlate);
                this.columnDriverName = new global::System.Data.DataColumn("DriverName", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnDriverName);
                this.columnDriverPhone = new global::System.Data.DataColumn("DriverPhone", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnDriverPhone);
                this.columnDriverIdNo = new global::System.Data.DataColumn("DriverIdNo", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnDriverIdNo);
                this.columnAssistantName = new global::System.Data.DataColumn("AssistantName", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnAssistantName);
                this.columnAssistantPhone = new global::System.Data.DataColumn("AssistantPhone", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnAssistantPhone);
                this.columnAssistantIdNo = new global::System.Data.DataColumn("AssistantIdNo", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnAssistantIdNo);
                this.columnContainerId = new global::System.Data.DataColumn("ContainerId", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnContainerId);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnUnitId}, true));
                this.columnUnitId.AutoIncrement = true;
                this.columnUnitId.AutoIncrementSeed = -1;
                this.columnUnitId.AutoIncrementStep = -1;
                this.columnUnitId.AllowDBNull = false;
                this.columnUnitId.ReadOnly = true;
                this.columnUnitId.Unique = true;
                this.columnVehicleNumberPlate.AllowDBNull = false;
                this.columnVehicleNumberPlate.MaxLength = 50;
                this.columnDriverName.AllowDBNull = false;
                this.columnDriverName.MaxLength = 100;
                this.columnDriverPhone.MaxLength = 50;
                this.columnDriverIdNo.MaxLength = 50;
                this.columnAssistantName.MaxLength = 100;
                this.columnAssistantPhone.MaxLength = 50;
                this.columnAssistantIdNo.MaxLength = 50;
                this.columnContainerId.MaxLength = 50;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public TransportUnitRow NewTransportUnitRow() {
                return ((TransportUnitRow)(this.NewRow()));
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new TransportUnitRow(builder);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(TransportUnitRow);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.TransportUnitRowChanged != null)) {
                    this.TransportUnitRowChanged(this, new TransportUnitRowChangeEvent(((TransportUnitRow)(e.Row)), e.Action));
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.TransportUnitRowChanging != null)) {
                    this.TransportUnitRowChanging(this, new TransportUnitRowChangeEvent(((TransportUnitRow)(e.Row)), e.Action));
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.TransportUnitRowDeleted != null)) {
                    this.TransportUnitRowDeleted(this, new TransportUnitRowChangeEvent(((TransportUnitRow)(e.Row)), e.Action));
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.TransportUnitRowDeleting != null)) {
                    this.TransportUnitRowDeleting(this, new TransportUnitRowChangeEvent(((TransportUnitRow)(e.Row)), e.Action));
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void RemoveTransportUnitRow(TransportUnitRow row) {
                this.Rows.Remove(row);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                eShiftDBDataSet1 ds = new eShiftDBDataSet1();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "TransportUnitDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        public partial class CustomerRow : global::System.Data.DataRow {
            private CustomerDataTable tableCustomer;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal CustomerRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableCustomer = ((CustomerDataTable)(this.Table));
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int CustomerId {
                get {
                    return ((int)(this[this.tableCustomer.CustomerIdColumn]));
                }
                set {
                    this[this.tableCustomer.CustomerIdColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string Name {
                get {
                    return ((string)(this[this.tableCustomer.NameColumn]));
                }
                set {
                    this[this.tableCustomer.NameColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string CustomerIdNo {
                get {
                    try {
                        return ((string)(this[this.tableCustomer.CustomerIdNoColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'CustomerIdNo\' in table \'Customer\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomer.CustomerIdNoColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string Phone {
                get {
                    try {
                        return ((string)(this[this.tableCustomer.PhoneColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Phone\' in table \'Customer\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomer.PhoneColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string Email {
                get {
                    try {
                        return ((string)(this[this.tableCustomer.EmailColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Email\' in table \'Customer\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomer.EmailColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string Address {
                get {
                    try {
                        return ((string)(this[this.tableCustomer.AddressColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Address\' in table \'Customer\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomer.AddressColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public bool IsCustomerIdNoNull() {
                return this.IsNull(this.tableCustomer.CustomerIdNoColumn);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void SetCustomerIdNoNull() {
                this[this.tableCustomer.CustomerIdNoColumn] = global::System.Convert.DBNull;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public bool IsPhoneNull() {
                return this.IsNull(this.tableCustomer.PhoneColumn);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void SetPhoneNull() {
                this[this.tableCustomer.PhoneColumn] = global::System.Convert.DBNull;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public bool IsEmailNull() {
                return this.IsNull(this.tableCustomer.EmailColumn);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void SetEmailNull() {
                this[this.tableCustomer.EmailColumn] = global::System.Convert.DBNull;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public bool IsAddressNull() {
                return this.IsNull(this.tableCustomer.AddressColumn);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void SetAddressNull() {
                this[this.tableCustomer.AddressColumn] = global::System.Convert.DBNull;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public JobRow[] GetJobRows() {
                if ((this.Table.ChildRelations["FK_Job_Customer"] == null)) {
                    return new JobRow[0];
                }
                else {
                    return ((JobRow[])(base.GetChildRows(this.Table.ChildRelations["FK_Job_Customer"])));
                }
            }
        }
        public partial class JobRow : global::System.Data.DataRow {
            private JobDataTable tableJob;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal JobRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableJob = ((JobDataTable)(this.Table));
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int JobId {
                get {
                    return ((int)(this[this.tableJob.JobIdColumn]));
                }
                set {
                    this[this.tableJob.JobIdColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int CustomerId {
                get {
                    return ((int)(this[this.tableJob.CustomerIdColumn]));
                }
                set {
                    this[this.tableJob.CustomerIdColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string StartLocation {
                get {
                    try {
                        return ((string)(this[this.tableJob.StartLocationColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'StartLocation\' in table \'Job\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableJob.StartLocationColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string Destination {
                get {
                    try {
                        return ((string)(this[this.tableJob.DestinationColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Destination\' in table \'Job\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableJob.DestinationColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public System.DateTime PickupDate {
                get {
                    try {
                        return ((global::System.DateTime)(this[this.tableJob.PickupDateColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'PickupDate\' in table \'Job\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableJob.PickupDateColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public System.DateTime DeliveryDate {
                get {
                    try {
                        return ((global::System.DateTime)(this[this.tableJob.DeliveryDateColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'DeliveryDate\' in table \'Job\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableJob.DeliveryDateColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string Status {
                get {
                    try {
                        return ((string)(this[this.tableJob.StatusColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Status\' in table \'Job\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableJob.StatusColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public CustomerRow CustomerRow {
                get {
                    return ((CustomerRow)(this.GetParentRow(this.Table.ParentRelations["FK_Job_Customer"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["FK_Job_Customer"]);
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public bool IsStartLocationNull() {
                return this.IsNull(this.tableJob.StartLocationColumn);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void SetStartLocationNull() {
                this[this.tableJob.StartLocationColumn] = global::System.Convert.DBNull;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public bool IsDestinationNull() {
                return this.IsNull(this.tableJob.DestinationColumn);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void SetDestinationNull() {
                this[this.tableJob.DestinationColumn] = global::System.Convert.DBNull;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public bool IsPickupDateNull() {
                return this.IsNull(this.tableJob.PickupDateColumn);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void SetPickupDateNull() {
                this[this.tableJob.PickupDateColumn] = global::System.Convert.DBNull;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public bool IsDeliveryDateNull() {
                return this.IsNull(this.tableJob.DeliveryDateColumn);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void SetDeliveryDateNull() {
                this[this.tableJob.DeliveryDateColumn] = global::System.Convert.DBNull;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public bool IsStatusNull() {
                return this.IsNull(this.tableJob.StatusColumn);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void SetStatusNull() {
                this[this.tableJob.StatusColumn] = global::System.Convert.DBNull;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public LoadRow[] GetLoadRows() {
                if ((this.Table.ChildRelations["FK_Load_Job"] == null)) {
                    return new LoadRow[0];
                }
                else {
                    return ((LoadRow[])(base.GetChildRows(this.Table.ChildRelations["FK_Load_Job"])));
                }
            }
        }
        public partial class LoadRow : global::System.Data.DataRow {
            private LoadDataTable tableLoad;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal LoadRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableLoad = ((LoadDataTable)(this.Table));
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int LoadId {
                get {
                    return ((int)(this[this.tableLoad.LoadIdColumn]));
                }
                set {
                    this[this.tableLoad.LoadIdColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int JobId {
                get {
                    return ((int)(this[this.tableLoad.JobIdColumn]));
                }
                set {
                    this[this.tableLoad.JobIdColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int TransportUnitId {
                get {
                    try {
                        return ((int)(this[this.tableLoad.TransportUnitIdColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'TransportUnitId\' in table \'Load\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableLoad.TransportUnitIdColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string Description {
                get {
                    try {
                        return ((string)(this[this.tableLoad.DescriptionColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Description\' in table \'Load\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableLoad.DescriptionColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public double WeightKg {
                get {
                    try {
                        return ((double)(this[this.tableLoad.WeightKgColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'WeightKg\' in table \'Load\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableLoad.WeightKgColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public JobRow JobRow {
                get {
                    return ((JobRow)(this.GetParentRow(this.Table.ParentRelations["FK_Load_Job"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["FK_Load_Job"]);
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public TransportUnitRow TransportUnitRow {
                get {
                    return ((TransportUnitRow)(this.GetParentRow(this.Table.ParentRelations["FK_Load_Unit"])));
                }
                set {
                    this.SetParentRow(value, this.Table.ParentRelations["FK_Load_Unit"]);
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public bool IsTransportUnitIdNull() {
                return this.IsNull(this.tableLoad.TransportUnitIdColumn);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void SetTransportUnitIdNull() {
                this[this.tableLoad.TransportUnitIdColumn] = global::System.Convert.DBNull;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public bool IsDescriptionNull() {
                return this.IsNull(this.tableLoad.DescriptionColumn);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void SetDescriptionNull() {
                this[this.tableLoad.DescriptionColumn] = global::System.Convert.DBNull;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public bool IsWeightKgNull() {
                return this.IsNull(this.tableLoad.WeightKgColumn);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void SetWeightKgNull() {
                this[this.tableLoad.WeightKgColumn] = global::System.Convert.DBNull;
            }
        }
        public partial class LoginRow : global::System.Data.DataRow {
            private LoginDataTable tableLogin;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal LoginRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableLogin = ((LoginDataTable)(this.Table));
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string UserName {
                get {
                    return ((string)(this[this.tableLogin.UserNameColumn]));
                }
                set {
                    this[this.tableLogin.UserNameColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string Password {
                get {
                    return ((string)(this[this.tableLogin.PasswordColumn]));
                }
                set {
                    this[this.tableLogin.PasswordColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string Role {
                get {
                    try {
                        return ((string)(this[this.tableLogin.RoleColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Role\' in table \'Login\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableLogin.RoleColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int idno {
                get {
                    return ((int)(this[this.tableLogin.idnoColumn]));
                }
                set {
                    this[this.tableLogin.idnoColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public bool IsRoleNull() {
                return this.IsNull(this.tableLogin.RoleColumn);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void SetRoleNull() {
                this[this.tableLogin.RoleColumn] = global::System.Convert.DBNull;
            }
        }
        public partial class TempCusDTLRow : global::System.Data.DataRow {
            private TempCusDTLDataTable tableTempCusDTL;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal TempCusDTLRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableTempCusDTL = ((TempCusDTLDataTable)(this.Table));
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int TemporyCus_ID {
                get {
                    return ((int)(this[this.tableTempCusDTL.TemporyCus_IDColumn]));
                }
                set {
                    this[this.tableTempCusDTL.TemporyCus_IDColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string Name {
                get {
                    return ((string)(this[this.tableTempCusDTL.NameColumn]));
                }
                set {
                    this[this.tableTempCusDTL.NameColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string NIC {
                get {
                    return ((string)(this[this.tableTempCusDTL.NICColumn]));
                }
                set {
                    this[this.tableTempCusDTL.NICColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string phone {
                get {
                    return ((string)(this[this.tableTempCusDTL.phoneColumn]));
                }
                set {
                    this[this.tableTempCusDTL.phoneColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string Email {
                get {
                    return ((string)(this[this.tableTempCusDTL.EmailColumn]));
                }
                set {
                    this[this.tableTempCusDTL.EmailColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string Address {
                get {
                    return ((string)(this[this.tableTempCusDTL.AddressColumn]));
                }
                set {
                    this[this.tableTempCusDTL.AddressColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string Item {
                get {
                    return ((string)(this[this.tableTempCusDTL.ItemColumn]));
                }
                set {
                    this[this.tableTempCusDTL.ItemColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string Start_Location {
                get {
                    return ((string)(this[this.tableTempCusDTL.Start_LocationColumn]));
                }
                set {
                    this[this.tableTempCusDTL.Start_LocationColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string Destination {
                get {
                    return ((string)(this[this.tableTempCusDTL.DestinationColumn]));
                }
                set {
                    this[this.tableTempCusDTL.DestinationColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public System.DateTime Date {
                get {
                    return ((global::System.DateTime)(this[this.tableTempCusDTL.DateColumn]));
                }
                set {
                    this[this.tableTempCusDTL.DateColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string Status {
                get {
                    try {
                        return ((string)(this[this.tableTempCusDTL.StatusColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Status\' in table \'TempCusDTL\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableTempCusDTL.StatusColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public bool IsStatusNull() {
                return this.IsNull(this.tableTempCusDTL.StatusColumn);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void SetStatusNull() {
                this[this.tableTempCusDTL.StatusColumn] = global::System.Convert.DBNull;
            }
        }
        public partial class TransportUnitRow : global::System.Data.DataRow {
            private TransportUnitDataTable tableTransportUnit;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal TransportUnitRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableTransportUnit = ((TransportUnitDataTable)(this.Table));
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int UnitId {
                get {
                    return ((int)(this[this.tableTransportUnit.UnitIdColumn]));
                }
                set {
                    this[this.tableTransportUnit.UnitIdColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string VehicleNumberPlate {
                get {
                    return ((string)(this[this.tableTransportUnit.VehicleNumberPlateColumn]));
                }
                set {
                    this[this.tableTransportUnit.VehicleNumberPlateColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string DriverName {
                get {
                    return ((string)(this[this.tableTransportUnit.DriverNameColumn]));
                }
                set {
                    this[this.tableTransportUnit.DriverNameColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string DriverPhone {
                get {
                    try {
                        return ((string)(this[this.tableTransportUnit.DriverPhoneColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'DriverPhone\' in table \'TransportUnit\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableTransportUnit.DriverPhoneColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string DriverIdNo {
                get {
                    try {
                        return ((string)(this[this.tableTransportUnit.DriverIdNoColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'DriverIdNo\' in table \'TransportUnit\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableTransportUnit.DriverIdNoColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string AssistantName {
                get {
                    try {
                        return ((string)(this[this.tableTransportUnit.AssistantNameColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'AssistantName\' in table \'TransportUnit\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableTransportUnit.AssistantNameColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string AssistantPhone {
                get {
                    try {
                        return ((string)(this[this.tableTransportUnit.AssistantPhoneColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'AssistantPhone\' in table \'TransportUnit\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableTransportUnit.AssistantPhoneColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string AssistantIdNo {
                get {
                    try {
                        return ((string)(this[this.tableTransportUnit.AssistantIdNoColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'AssistantIdNo\' in table \'TransportUnit\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableTransportUnit.AssistantIdNoColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public string ContainerId {
                get {
                    try {
                        return ((string)(this[this.tableTransportUnit.ContainerIdColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'ContainerId\' in table \'TransportUnit\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableTransportUnit.ContainerIdColumn] = value;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public bool IsDriverPhoneNull() {
                return this.IsNull(this.tableTransportUnit.DriverPhoneColumn);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void SetDriverPhoneNull() {
                this[this.tableTransportUnit.DriverPhoneColumn] = global::System.Convert.DBNull;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public bool IsDriverIdNoNull() {
                return this.IsNull(this.tableTransportUnit.DriverIdNoColumn);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void SetDriverIdNoNull() {
                this[this.tableTransportUnit.DriverIdNoColumn] = global::System.Convert.DBNull;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public bool IsAssistantNameNull() {
                return this.IsNull(this.tableTransportUnit.AssistantNameColumn);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void SetAssistantNameNull() {
                this[this.tableTransportUnit.AssistantNameColumn] = global::System.Convert.DBNull;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public bool IsAssistantPhoneNull() {
                return this.IsNull(this.tableTransportUnit.AssistantPhoneColumn);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void SetAssistantPhoneNull() {
                this[this.tableTransportUnit.AssistantPhoneColumn] = global::System.Convert.DBNull;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public bool IsAssistantIdNoNull() {
                return this.IsNull(this.tableTransportUnit.AssistantIdNoColumn);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void SetAssistantIdNoNull() {
                this[this.tableTransportUnit.AssistantIdNoColumn] = global::System.Convert.DBNull;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public bool IsContainerIdNull() {
                return this.IsNull(this.tableTransportUnit.ContainerIdColumn);
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public void SetContainerIdNull() {
                this[this.tableTransportUnit.ContainerIdColumn] = global::System.Convert.DBNull;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public LoadRow[] GetLoadRows() {
                if ((this.Table.ChildRelations["FK_Load_Unit"] == null)) {
                    return new LoadRow[0];
                }
                else {
                    return ((LoadRow[])(base.GetChildRows(this.Table.ChildRelations["FK_Load_Unit"])));
                }
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public class CustomerRowChangeEvent : global::System.EventArgs {
            private CustomerRow eventRow;
            private global::System.Data.DataRowAction eventAction;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public CustomerRowChangeEvent(CustomerRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public CustomerRow Row {
                get {
                    return this.eventRow;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public class JobRowChangeEvent : global::System.EventArgs {
            private JobRow eventRow;
            private global::System.Data.DataRowAction eventAction;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public JobRowChangeEvent(JobRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public JobRow Row {
                get {
                    return this.eventRow;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public class LoadRowChangeEvent : global::System.EventArgs {
            private LoadRow eventRow;
            private global::System.Data.DataRowAction eventAction;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public LoadRowChangeEvent(LoadRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public LoadRow Row {
                get {
                    return this.eventRow;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public class LoginRowChangeEvent : global::System.EventArgs {
            private LoginRow eventRow;
            private global::System.Data.DataRowAction eventAction;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public LoginRowChangeEvent(LoginRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public LoginRow Row {
                get {
                    return this.eventRow;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public class TempCusDTLRowChangeEvent : global::System.EventArgs {
            private TempCusDTLRow eventRow;
            private global::System.Data.DataRowAction eventAction;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public TempCusDTLRowChangeEvent(TempCusDTLRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public TempCusDTLRow Row {
                get {
                    return this.eventRow;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public class TransportUnitRowChangeEvent : global::System.EventArgs {
            private TransportUnitRow eventRow;
            private global::System.Data.DataRowAction eventAction;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public TransportUnitRowChangeEvent(TransportUnitRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public TransportUnitRow Row {
                get {
                    return this.eventRow;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
namespace ESHIFT.eShiftDBDataSet1TableAdapters {
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class CustomerTableAdapter : global::System.ComponentModel.Component {
        private global::System.Data.SqlClient.SqlDataAdapter _adapter;
        private global::System.Data.SqlClient.SqlConnection _connection;
        private global::System.Data.SqlClient.SqlTransaction _transaction;
        private global::System.Data.SqlClient.SqlCommand[] _commandCollection;
        private bool _clearBeforeFill;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public CustomerTableAdapter() {
            this.ClearBeforeFill = true;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected internal global::System.Data.SqlClient.SqlDataAdapter Adapter {
            get {
                if ((this._adapter == null)) {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        internal global::System.Data.SqlClient.SqlConnection Connection {
            get {
                if ((this._connection == null)) {
                    this.InitConnection();
                }
                return this._connection;
            }
            set {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null)) {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null)) {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null)) {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    if ((this.CommandCollection[i] != null)) {
                        ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        internal global::System.Data.SqlClient.SqlTransaction Transaction {
            get {
                return this._transaction;
            }
            set {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.DeleteCommand != null))) {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.InsertCommand != null))) {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.UpdateCommand != null))) {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected global::System.Data.SqlClient.SqlCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public bool ClearBeforeFill {
            get {
                return this._clearBeforeFill;
            }
            set {
                this._clearBeforeFill = value;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitAdapter() {
            this._adapter = new global::System.Data.SqlClient.SqlDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Customer";
            tableMapping.ColumnMappings.Add("CustomerId", "CustomerId");
            tableMapping.ColumnMappings.Add("Name", "Name");
            tableMapping.ColumnMappings.Add("CustomerIdNo", "CustomerIdNo");
            tableMapping.ColumnMappings.Add("Phone", "Phone");
            tableMapping.ColumnMappings.Add("Email", "Email");
            tableMapping.ColumnMappings.Add("Address", "Address");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = @"DELETE FROM [dbo].[Customer] WHERE (([CustomerId] = @Original_CustomerId) AND ([Name] = @Original_Name) AND ((@IsNull_CustomerIdNo = 1 AND [CustomerIdNo] IS NULL) OR ([CustomerIdNo] = @Original_CustomerIdNo)) AND ((@IsNull_Phone = 1 AND [Phone] IS NULL) OR ([Phone] = @Original_Phone)) AND ((@IsNull_Email = 1 AND [Email] IS NULL) OR ([Email] = @Original_Email)) AND ((@IsNull_Address = 1 AND [Address] IS NULL) OR ([Address] = @Original_Address)))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_CustomerId", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CustomerId", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Name", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Name", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_CustomerIdNo", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CustomerIdNo", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_CustomerIdNo", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CustomerIdNo", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_Phone", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Phone", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Phone", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Phone", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_Email", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Email", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Email", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Email", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_Address", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Address", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Address", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Address", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.InsertCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[Customer] ([Name], [CustomerIdNo], [Phone], [Email], [Address]" +
                ") VALUES (@Name, @CustomerIdNo, @Phone, @Email, @Address);\r\nSELECT CustomerId, N" +
                "ame, CustomerIdNo, Phone, Email, Address FROM Customer WHERE (CustomerId = SCOPE" +
                "_IDENTITY())";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Name", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Name", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@CustomerIdNo", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CustomerIdNo", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Phone", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Phone", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Email", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Email", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Address", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Address", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = @"UPDATE [dbo].[Customer] SET [Name] = @Name, [CustomerIdNo] = @CustomerIdNo, [Phone] = @Phone, [Email] = @Email, [Address] = @Address WHERE (([CustomerId] = @Original_CustomerId) AND ([Name] = @Original_Name) AND ((@IsNull_CustomerIdNo = 1 AND [CustomerIdNo] IS NULL) OR ([CustomerIdNo] = @Original_CustomerIdNo)) AND ((@IsNull_Phone = 1 AND [Phone] IS NULL) OR ([Phone] = @Original_Phone)) AND ((@IsNull_Email = 1 AND [Email] IS NULL) OR ([Email] = @Original_Email)) AND ((@IsNull_Address = 1 AND [Address] IS NULL) OR ([Address] = @Original_Address)));
SELECT CustomerId, Name, CustomerIdNo, Phone, Email, Address FROM Customer WHERE (CustomerId = @CustomerId)";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Name", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Name", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@CustomerIdNo", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CustomerIdNo", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Phone", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Phone", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Email", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Email", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Address", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Address", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_CustomerId", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CustomerId", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Name", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Name", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_CustomerIdNo", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CustomerIdNo", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_CustomerIdNo", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CustomerIdNo", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_Phone", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Phone", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Phone", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Phone", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_Email", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Email", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Email", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Email", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_Address", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Address", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Address", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Address", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@CustomerId", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "CustomerId", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitConnection() {
            this._connection = new global::System.Data.SqlClient.SqlConnection();
            this._connection.ConnectionString = global::ESHIFT.Properties.Settings.Default.eShiftDBConnectionString;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.SqlClient.SqlCommand[1];
            this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT CustomerId, Name, CustomerIdNo, Phone, Email, Address FROM dbo.Customer";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(eShiftDBDataSet1.CustomerDataTable dataTable) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual eShiftDBDataSet1.CustomerDataTable GetData() {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            eShiftDBDataSet1.CustomerDataTable dataTable = new eShiftDBDataSet1.CustomerDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(eShiftDBDataSet1.CustomerDataTable dataTable) {
            return this.Adapter.Update(dataTable);
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(eShiftDBDataSet1 dataSet) {
            return this.Adapter.Update(dataSet, "Customer");
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow) {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows) {
            return this.Adapter.Update(dataRows);
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int Original_CustomerId, string Original_Name, string Original_CustomerIdNo, string Original_Phone, string Original_Email, string Original_Address) {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(Original_CustomerId));
            if ((Original_Name == null)) {
                throw new global::System.ArgumentNullException("Original_Name");
            }
            else {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((string)(Original_Name));
            }
            if ((Original_CustomerIdNo == null)) {
                this.Adapter.DeleteCommand.Parameters[2].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[2].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[3].Value = ((string)(Original_CustomerIdNo));
            }
            if ((Original_Phone == null)) {
                this.Adapter.DeleteCommand.Parameters[4].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[4].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[5].Value = ((string)(Original_Phone));
            }
            if ((Original_Email == null)) {
                this.Adapter.DeleteCommand.Parameters[6].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[6].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[7].Value = ((string)(Original_Email));
            }
            if ((Original_Address == null)) {
                this.Adapter.DeleteCommand.Parameters[8].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[9].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[8].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[9].Value = ((string)(Original_Address));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string Name, string CustomerIdNo, string Phone, string Email, string Address) {
            if ((Name == null)) {
                throw new global::System.ArgumentNullException("Name");
            }
            else {
                this.Adapter.InsertCommand.Parameters[0].Value = ((string)(Name));
            }
            if ((CustomerIdNo == null)) {
                this.Adapter.InsertCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[1].Value = ((string)(CustomerIdNo));
            }
            if ((Phone == null)) {
                this.Adapter.InsertCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[2].Value = ((string)(Phone));
            }
            if ((Email == null)) {
                this.Adapter.InsertCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[3].Value = ((string)(Email));
            }
            if ((Address == null)) {
                this.Adapter.InsertCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[4].Value = ((string)(Address));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string Name, string CustomerIdNo, string Phone, string Email, string Address, int Original_CustomerId, string Original_Name, string Original_CustomerIdNo, string Original_Phone, string Original_Email, string Original_Address, int CustomerId) {
            if ((Name == null)) {
                throw new global::System.ArgumentNullException("Name");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((string)(Name));
            }
            if ((CustomerIdNo == null)) {
                this.Adapter.UpdateCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((string)(CustomerIdNo));
            }
            if ((Phone == null)) {
                this.Adapter.UpdateCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[2].Value = ((string)(Phone));
            }
            if ((Email == null)) {
                this.Adapter.UpdateCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((string)(Email));
            }
            if ((Address == null)) {
                this.Adapter.UpdateCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((string)(Address));
            }
            this.Adapter.UpdateCommand.Parameters[5].Value = ((int)(Original_CustomerId));
            if ((Original_Name == null)) {
                throw new global::System.ArgumentNullException("Original_Name");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((string)(Original_Name));
            }
            if ((Original_CustomerIdNo == null)) {
                this.Adapter.UpdateCommand.Parameters[7].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[8].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[7].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[8].Value = ((string)(Original_CustomerIdNo));
            }
            if ((Original_Phone == null)) {
                this.Adapter.UpdateCommand.Parameters[9].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[10].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[9].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[10].Value = ((string)(Original_Phone));
            }
            if ((Original_Email == null)) {
                this.Adapter.UpdateCommand.Parameters[11].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[12].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[11].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[12].Value = ((string)(Original_Email));
            }
            if ((Original_Address == null)) {
                this.Adapter.UpdateCommand.Parameters[13].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[14].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[13].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[14].Value = ((string)(Original_Address));
            }
            this.Adapter.UpdateCommand.Parameters[15].Value = ((int)(CustomerId));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string Name, string CustomerIdNo, string Phone, string Email, string Address, int Original_CustomerId, string Original_Name, string Original_CustomerIdNo, string Original_Phone, string Original_Email, string Original_Address) {
            return this.Update(Name, CustomerIdNo, Phone, Email, Address, Original_CustomerId, Original_Name, Original_CustomerIdNo, Original_Phone, Original_Email, Original_Address, Original_CustomerId);
        }
    }
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class JobTableAdapter : global::System.ComponentModel.Component {
        private global::System.Data.SqlClient.SqlDataAdapter _adapter;
        private global::System.Data.SqlClient.SqlConnection _connection;
        private global::System.Data.SqlClient.SqlTransaction _transaction;
        private global::System.Data.SqlClient.SqlCommand[] _commandCollection;
        private bool _clearBeforeFill;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public JobTableAdapter() {
            this.ClearBeforeFill = true;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected internal global::System.Data.SqlClient.SqlDataAdapter Adapter {
            get {
                if ((this._adapter == null)) {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        internal global::System.Data.SqlClient.SqlConnection Connection {
            get {
                if ((this._connection == null)) {
                    this.InitConnection();
                }
                return this._connection;
            }
            set {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null)) {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null)) {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null)) {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    if ((this.CommandCollection[i] != null)) {
                        ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        internal global::System.Data.SqlClient.SqlTransaction Transaction {
            get {
                return this._transaction;
            }
            set {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.DeleteCommand != null))) {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.InsertCommand != null))) {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.UpdateCommand != null))) {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected global::System.Data.SqlClient.SqlCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public bool ClearBeforeFill {
            get {
                return this._clearBeforeFill;
            }
            set {
                this._clearBeforeFill = value;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitAdapter() {
            this._adapter = new global::System.Data.SqlClient.SqlDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Job";
            tableMapping.ColumnMappings.Add("JobId", "JobId");
            tableMapping.ColumnMappings.Add("CustomerId", "CustomerId");
            tableMapping.ColumnMappings.Add("StartLocation", "StartLocation");
            tableMapping.ColumnMappings.Add("Destination", "Destination");
            tableMapping.ColumnMappings.Add("PickupDate", "PickupDate");
            tableMapping.ColumnMappings.Add("DeliveryDate", "DeliveryDate");
            tableMapping.ColumnMappings.Add("Status", "Status");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = @"DELETE FROM [dbo].[Job] WHERE (([JobId] = @Original_JobId) AND ([CustomerId] = @Original_CustomerId) AND ((@IsNull_StartLocation = 1 AND [StartLocation] IS NULL) OR ([StartLocation] = @Original_StartLocation)) AND ((@IsNull_Destination = 1 AND [Destination] IS NULL) OR ([Destination] = @Original_Destination)) AND ((@IsNull_PickupDate = 1 AND [PickupDate] IS NULL) OR ([PickupDate] = @Original_PickupDate)) AND ((@IsNull_DeliveryDate = 1 AND [DeliveryDate] IS NULL) OR ([DeliveryDate] = @Original_DeliveryDate)) AND ((@IsNull_Status = 1 AND [Status] IS NULL) OR ([Status] = @Original_Status)))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_JobId", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "JobId", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_CustomerId", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CustomerId", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_StartLocation", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "StartLocation", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_StartLocation", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "StartLocation", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_Destination", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Destination", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Destination", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Destination", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_PickupDate", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "PickupDate", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_PickupDate", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "PickupDate", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_DeliveryDate", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DeliveryDate", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_DeliveryDate", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DeliveryDate", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_Status", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Status", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Status", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Status", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.InsertCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = @"INSERT INTO [dbo].[Job] ([CustomerId], [StartLocation], [Destination], [PickupDate], [DeliveryDate], [Status]) VALUES (@CustomerId, @StartLocation, @Destination, @PickupDate, @DeliveryDate, @Status);
SELECT JobId, CustomerId, StartLocation, Destination, PickupDate, DeliveryDate, Status FROM Job WHERE (JobId = SCOPE_IDENTITY())";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@CustomerId", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CustomerId", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@StartLocation", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "StartLocation", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Destination", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Destination", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@PickupDate", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "PickupDate", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@DeliveryDate", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DeliveryDate", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Status", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Status", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = @"UPDATE [dbo].[Job] SET [CustomerId] = @CustomerId, [StartLocation] = @StartLocation, [Destination] = @Destination, [PickupDate] = @PickupDate, [DeliveryDate] = @DeliveryDate, [Status] = @Status WHERE (([JobId] = @Original_JobId) AND ([CustomerId] = @Original_CustomerId) AND ((@IsNull_StartLocation = 1 AND [StartLocation] IS NULL) OR ([StartLocation] = @Original_StartLocation)) AND ((@IsNull_Destination = 1 AND [Destination] IS NULL) OR ([Destination] = @Original_Destination)) AND ((@IsNull_PickupDate = 1 AND [PickupDate] IS NULL) OR ([PickupDate] = @Original_PickupDate)) AND ((@IsNull_DeliveryDate = 1 AND [DeliveryDate] IS NULL) OR ([DeliveryDate] = @Original_DeliveryDate)) AND ((@IsNull_Status = 1 AND [Status] IS NULL) OR ([Status] = @Original_Status)));
SELECT JobId, CustomerId, StartLocation, Destination, PickupDate, DeliveryDate, Status FROM Job WHERE (JobId = @JobId)";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@CustomerId", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CustomerId", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@StartLocation", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "StartLocation", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Destination", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Destination", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@PickupDate", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "PickupDate", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@DeliveryDate", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DeliveryDate", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Status", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Status", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_JobId", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "JobId", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_CustomerId", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "CustomerId", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_StartLocation", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "StartLocation", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_StartLocation", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "StartLocation", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_Destination", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Destination", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Destination", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Destination", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_PickupDate", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "PickupDate", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_PickupDate", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "PickupDate", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_DeliveryDate", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DeliveryDate", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_DeliveryDate", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DeliveryDate", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_Status", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Status", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Status", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Status", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@JobId", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "JobId", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitConnection() {
            this._connection = new global::System.Data.SqlClient.SqlConnection();
            this._connection.ConnectionString = global::ESHIFT.Properties.Settings.Default.eShiftDBConnectionString;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.SqlClient.SqlCommand[1];
            this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT JobId, CustomerId, StartLocation, Destination, PickupDate, DeliveryDate, S" +
                "tatus FROM dbo.Job";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(eShiftDBDataSet1.JobDataTable dataTable) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual eShiftDBDataSet1.JobDataTable GetData() {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            eShiftDBDataSet1.JobDataTable dataTable = new eShiftDBDataSet1.JobDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(eShiftDBDataSet1.JobDataTable dataTable) {
            return this.Adapter.Update(dataTable);
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(eShiftDBDataSet1 dataSet) {
            return this.Adapter.Update(dataSet, "Job");
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow) {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows) {
            return this.Adapter.Update(dataRows);
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int Original_JobId, int Original_CustomerId, string Original_StartLocation, string Original_Destination, global::System.Nullable<global::System.DateTime> Original_PickupDate, global::System.Nullable<global::System.DateTime> Original_DeliveryDate, string Original_Status) {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(Original_JobId));
            this.Adapter.DeleteCommand.Parameters[1].Value = ((int)(Original_CustomerId));
            if ((Original_StartLocation == null)) {
                this.Adapter.DeleteCommand.Parameters[2].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[2].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[3].Value = ((string)(Original_StartLocation));
            }
            if ((Original_Destination == null)) {
                this.Adapter.DeleteCommand.Parameters[4].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[4].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[5].Value = ((string)(Original_Destination));
            }
            if ((Original_PickupDate.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[6].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[7].Value = ((System.DateTime)(Original_PickupDate.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[6].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            if ((Original_DeliveryDate.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[8].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[9].Value = ((System.DateTime)(Original_DeliveryDate.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[8].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[9].Value = global::System.DBNull.Value;
            }
            if ((Original_Status == null)) {
                this.Adapter.DeleteCommand.Parameters[10].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[11].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[10].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[11].Value = ((string)(Original_Status));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(int CustomerId, string StartLocation, string Destination, global::System.Nullable<global::System.DateTime> PickupDate, global::System.Nullable<global::System.DateTime> DeliveryDate, string Status) {
            this.Adapter.InsertCommand.Parameters[0].Value = ((int)(CustomerId));
            if ((StartLocation == null)) {
                this.Adapter.InsertCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[1].Value = ((string)(StartLocation));
            }
            if ((Destination == null)) {
                this.Adapter.InsertCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[2].Value = ((string)(Destination));
            }
            if ((PickupDate.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[3].Value = ((System.DateTime)(PickupDate.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((DeliveryDate.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[4].Value = ((System.DateTime)(DeliveryDate.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((Status == null)) {
                this.Adapter.InsertCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[5].Value = ((string)(Status));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(int CustomerId, string StartLocation, string Destination, global::System.Nullable<global::System.DateTime> PickupDate, global::System.Nullable<global::System.DateTime> DeliveryDate, string Status, int Original_JobId, int Original_CustomerId, string Original_StartLocation, string Original_Destination, global::System.Nullable<global::System.DateTime> Original_PickupDate, global::System.Nullable<global::System.DateTime> Original_DeliveryDate, string Original_Status, int JobId) {
            this.Adapter.UpdateCommand.Parameters[0].Value = ((int)(CustomerId));
            if ((StartLocation == null)) {
                this.Adapter.UpdateCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((string)(StartLocation));
            }
            if ((Destination == null)) {
                this.Adapter.UpdateCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[2].Value = ((string)(Destination));
            }
            if ((PickupDate.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((System.DateTime)(PickupDate.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((DeliveryDate.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((System.DateTime)(DeliveryDate.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((Status == null)) {
                this.Adapter.UpdateCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((string)(Status));
            }
            this.Adapter.UpdateCommand.Parameters[6].Value = ((int)(Original_JobId));
            this.Adapter.UpdateCommand.Parameters[7].Value = ((int)(Original_CustomerId));
            if ((Original_StartLocation == null)) {
                this.Adapter.UpdateCommand.Parameters[8].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[9].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[8].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[9].Value = ((string)(Original_StartLocation));
            }
            if ((Original_Destination == null)) {
                this.Adapter.UpdateCommand.Parameters[10].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[11].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[10].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[11].Value = ((string)(Original_Destination));
            }
            if ((Original_PickupDate.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[12].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[13].Value = ((System.DateTime)(Original_PickupDate.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[12].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[13].Value = global::System.DBNull.Value;
            }
            if ((Original_DeliveryDate.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[14].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[15].Value = ((System.DateTime)(Original_DeliveryDate.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[14].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[15].Value = global::System.DBNull.Value;
            }
            if ((Original_Status == null)) {
                this.Adapter.UpdateCommand.Parameters[16].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[17].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[16].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[17].Value = ((string)(Original_Status));
            }
            this.Adapter.UpdateCommand.Parameters[18].Value = ((int)(JobId));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(int CustomerId, string StartLocation, string Destination, global::System.Nullable<global::System.DateTime> PickupDate, global::System.Nullable<global::System.DateTime> DeliveryDate, string Status, int Original_JobId, int Original_CustomerId, string Original_StartLocation, string Original_Destination, global::System.Nullable<global::System.DateTime> Original_PickupDate, global::System.Nullable<global::System.DateTime> Original_DeliveryDate, string Original_Status) {
            return this.Update(CustomerId, StartLocation, Destination, PickupDate, DeliveryDate, Status, Original_JobId, Original_CustomerId, Original_StartLocation, Original_Destination, Original_PickupDate, Original_DeliveryDate, Original_Status, Original_JobId);
        }
    }
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class LoadTableAdapter : global::System.ComponentModel.Component {
        private global::System.Data.SqlClient.SqlDataAdapter _adapter;
        private global::System.Data.SqlClient.SqlConnection _connection;
        private global::System.Data.SqlClient.SqlTransaction _transaction;
        private global::System.Data.SqlClient.SqlCommand[] _commandCollection;
        private bool _clearBeforeFill;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public LoadTableAdapter() {
            this.ClearBeforeFill = true;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected internal global::System.Data.SqlClient.SqlDataAdapter Adapter {
            get {
                if ((this._adapter == null)) {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        internal global::System.Data.SqlClient.SqlConnection Connection {
            get {
                if ((this._connection == null)) {
                    this.InitConnection();
                }
                return this._connection;
            }
            set {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null)) {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null)) {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null)) {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    if ((this.CommandCollection[i] != null)) {
                        ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        internal global::System.Data.SqlClient.SqlTransaction Transaction {
            get {
                return this._transaction;
            }
            set {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.DeleteCommand != null))) {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.InsertCommand != null))) {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.UpdateCommand != null))) {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected global::System.Data.SqlClient.SqlCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public bool ClearBeforeFill {
            get {
                return this._clearBeforeFill;
            }
            set {
                this._clearBeforeFill = value;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitAdapter() {
            this._adapter = new global::System.Data.SqlClient.SqlDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Load";
            tableMapping.ColumnMappings.Add("LoadId", "LoadId");
            tableMapping.ColumnMappings.Add("JobId", "JobId");
            tableMapping.ColumnMappings.Add("TransportUnitId", "TransportUnitId");
            tableMapping.ColumnMappings.Add("Description", "Description");
            tableMapping.ColumnMappings.Add("WeightKg", "WeightKg");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = @"DELETE FROM [dbo].[Load] WHERE (([LoadId] = @Original_LoadId) AND ([JobId] = @Original_JobId) AND ((@IsNull_TransportUnitId = 1 AND [TransportUnitId] IS NULL) OR ([TransportUnitId] = @Original_TransportUnitId)) AND ((@IsNull_Description = 1 AND [Description] IS NULL) OR ([Description] = @Original_Description)) AND ((@IsNull_WeightKg = 1 AND [WeightKg] IS NULL) OR ([WeightKg] = @Original_WeightKg)))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_LoadId", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "LoadId", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_JobId", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "JobId", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_TransportUnitId", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "TransportUnitId", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_TransportUnitId", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "TransportUnitId", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_Description", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Description", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Description", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Description", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_WeightKg", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "WeightKg", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_WeightKg", global::System.Data.SqlDbType.Float, 0, global::System.Data.ParameterDirection.Input, 0, 0, "WeightKg", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.InsertCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[Load] ([JobId], [TransportUnitId], [Description], [WeightKg]) " +
                "VALUES (@JobId, @TransportUnitId, @Description, @WeightKg);\r\nSELECT LoadId, JobI" +
                "d, TransportUnitId, Description, WeightKg FROM [Load] WHERE (LoadId = SCOPE_IDEN" +
                "TITY())";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@JobId", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "JobId", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@TransportUnitId", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "TransportUnitId", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Description", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Description", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@WeightKg", global::System.Data.SqlDbType.Float, 0, global::System.Data.ParameterDirection.Input, 0, 0, "WeightKg", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = @"UPDATE [dbo].[Load] SET [JobId] = @JobId, [TransportUnitId] = @TransportUnitId, [Description] = @Description, [WeightKg] = @WeightKg WHERE (([LoadId] = @Original_LoadId) AND ([JobId] = @Original_JobId) AND ((@IsNull_TransportUnitId = 1 AND [TransportUnitId] IS NULL) OR ([TransportUnitId] = @Original_TransportUnitId)) AND ((@IsNull_Description = 1 AND [Description] IS NULL) OR ([Description] = @Original_Description)) AND ((@IsNull_WeightKg = 1 AND [WeightKg] IS NULL) OR ([WeightKg] = @Original_WeightKg)));
SELECT LoadId, JobId, TransportUnitId, Description, WeightKg FROM [Load] WHERE (LoadId = @LoadId)";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@JobId", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "JobId", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@TransportUnitId", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "TransportUnitId", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Description", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Description", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@WeightKg", global::System.Data.SqlDbType.Float, 0, global::System.Data.ParameterDirection.Input, 0, 0, "WeightKg", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_LoadId", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "LoadId", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_JobId", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "JobId", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_TransportUnitId", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "TransportUnitId", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_TransportUnitId", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "TransportUnitId", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_Description", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Description", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Description", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Description", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_WeightKg", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "WeightKg", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_WeightKg", global::System.Data.SqlDbType.Float, 0, global::System.Data.ParameterDirection.Input, 0, 0, "WeightKg", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@LoadId", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "LoadId", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitConnection() {
            this._connection = new global::System.Data.SqlClient.SqlConnection();
            this._connection.ConnectionString = global::ESHIFT.Properties.Settings.Default.eShiftDBConnectionString;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.SqlClient.SqlCommand[1];
            this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT LoadId, JobId, TransportUnitId, Description, WeightKg FROM dbo.[Load]";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(eShiftDBDataSet1.LoadDataTable dataTable) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual eShiftDBDataSet1.LoadDataTable GetData() {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            eShiftDBDataSet1.LoadDataTable dataTable = new eShiftDBDataSet1.LoadDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(eShiftDBDataSet1.LoadDataTable dataTable) {
            return this.Adapter.Update(dataTable);
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(eShiftDBDataSet1 dataSet) {
            return this.Adapter.Update(dataSet, "Load");
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow) {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows) {
            return this.Adapter.Update(dataRows);
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int Original_LoadId, int Original_JobId, global::System.Nullable<int> Original_TransportUnitId, string Original_Description, global::System.Nullable<double> Original_WeightKg) {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(Original_LoadId));
            this.Adapter.DeleteCommand.Parameters[1].Value = ((int)(Original_JobId));
            if ((Original_TransportUnitId.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[2].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[3].Value = ((int)(Original_TransportUnitId.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[2].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((Original_Description == null)) {
                this.Adapter.DeleteCommand.Parameters[4].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[4].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[5].Value = ((string)(Original_Description));
            }
            if ((Original_WeightKg.HasValue == true)) {
                this.Adapter.DeleteCommand.Parameters[6].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[7].Value = ((double)(Original_WeightKg.Value));
            }
            else {
                this.Adapter.DeleteCommand.Parameters[6].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(int JobId, global::System.Nullable<int> TransportUnitId, string Description, global::System.Nullable<double> WeightKg) {
            this.Adapter.InsertCommand.Parameters[0].Value = ((int)(JobId));
            if ((TransportUnitId.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[1].Value = ((int)(TransportUnitId.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((Description == null)) {
                this.Adapter.InsertCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[2].Value = ((string)(Description));
            }
            if ((WeightKg.HasValue == true)) {
                this.Adapter.InsertCommand.Parameters[3].Value = ((double)(WeightKg.Value));
            }
            else {
                this.Adapter.InsertCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(int JobId, global::System.Nullable<int> TransportUnitId, string Description, global::System.Nullable<double> WeightKg, int Original_LoadId, int Original_JobId, global::System.Nullable<int> Original_TransportUnitId, string Original_Description, global::System.Nullable<double> Original_WeightKg, int LoadId) {
            this.Adapter.UpdateCommand.Parameters[0].Value = ((int)(JobId));
            if ((TransportUnitId.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((int)(TransportUnitId.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((Description == null)) {
                this.Adapter.UpdateCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[2].Value = ((string)(Description));
            }
            if ((WeightKg.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((double)(WeightKg.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            this.Adapter.UpdateCommand.Parameters[4].Value = ((int)(Original_LoadId));
            this.Adapter.UpdateCommand.Parameters[5].Value = ((int)(Original_JobId));
            if ((Original_TransportUnitId.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[7].Value = ((int)(Original_TransportUnitId.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            if ((Original_Description == null)) {
                this.Adapter.UpdateCommand.Parameters[8].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[9].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[8].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[9].Value = ((string)(Original_Description));
            }
            if ((Original_WeightKg.HasValue == true)) {
                this.Adapter.UpdateCommand.Parameters[10].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[11].Value = ((double)(Original_WeightKg.Value));
            }
            else {
                this.Adapter.UpdateCommand.Parameters[10].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[11].Value = global::System.DBNull.Value;
            }
            this.Adapter.UpdateCommand.Parameters[12].Value = ((int)(LoadId));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(int JobId, global::System.Nullable<int> TransportUnitId, string Description, global::System.Nullable<double> WeightKg, int Original_LoadId, int Original_JobId, global::System.Nullable<int> Original_TransportUnitId, string Original_Description, global::System.Nullable<double> Original_WeightKg) {
            return this.Update(JobId, TransportUnitId, Description, WeightKg, Original_LoadId, Original_JobId, Original_TransportUnitId, Original_Description, Original_WeightKg, Original_LoadId);
        }
    }
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class LoginTableAdapter : global::System.ComponentModel.Component {
        private global::System.Data.SqlClient.SqlDataAdapter _adapter;
        private global::System.Data.SqlClient.SqlConnection _connection;
        private global::System.Data.SqlClient.SqlTransaction _transaction;
        private global::System.Data.SqlClient.SqlCommand[] _commandCollection;
        private bool _clearBeforeFill;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public LoginTableAdapter() {
            this.ClearBeforeFill = true;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected internal global::System.Data.SqlClient.SqlDataAdapter Adapter {
            get {
                if ((this._adapter == null)) {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        internal global::System.Data.SqlClient.SqlConnection Connection {
            get {
                if ((this._connection == null)) {
                    this.InitConnection();
                }
                return this._connection;
            }
            set {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null)) {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null)) {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null)) {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    if ((this.CommandCollection[i] != null)) {
                        ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        internal global::System.Data.SqlClient.SqlTransaction Transaction {
            get {
                return this._transaction;
            }
            set {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.DeleteCommand != null))) {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.InsertCommand != null))) {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.UpdateCommand != null))) {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected global::System.Data.SqlClient.SqlCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public bool ClearBeforeFill {
            get {
                return this._clearBeforeFill;
            }
            set {
                this._clearBeforeFill = value;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitAdapter() {
            this._adapter = new global::System.Data.SqlClient.SqlDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "Login";
            tableMapping.ColumnMappings.Add("UserName", "UserName");
            tableMapping.ColumnMappings.Add("Password", "Password");
            tableMapping.ColumnMappings.Add("Role", "Role");
            tableMapping.ColumnMappings.Add("idno", "idno");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[Login] WHERE (([UserName] = @Original_UserName) AND ([Password" +
                "] = @Original_Password) AND ((@IsNull_Role = 1 AND [Role] IS NULL) OR ([Role] = " +
                "@Original_Role)) AND ([idno] = @Original_idno))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_UserName", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "UserName", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Password", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Password", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_Role", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Role", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Role", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Role", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_idno", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "idno", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.InsertCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[Login] ([UserName], [Password], [Role]) VALUES (@UserName, @Pa" +
                "ssword, @Role);\r\nSELECT UserName, Password, Role, idno FROM Login WHERE (idno = " +
                "SCOPE_IDENTITY())";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@UserName", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "UserName", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Password", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Password", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Role", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Role", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = @"UPDATE [dbo].[Login] SET [UserName] = @UserName, [Password] = @Password, [Role] = @Role WHERE (([UserName] = @Original_UserName) AND ([Password] = @Original_Password) AND ((@IsNull_Role = 1 AND [Role] IS NULL) OR ([Role] = @Original_Role)) AND ([idno] = @Original_idno));
SELECT UserName, Password, Role, idno FROM Login WHERE (idno = @idno)";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@UserName", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "UserName", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Password", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Password", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Role", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Role", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_UserName", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "UserName", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Password", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Password", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_Role", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Role", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Role", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Role", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_idno", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "idno", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@idno", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "idno", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitConnection() {
            this._connection = new global::System.Data.SqlClient.SqlConnection();
            this._connection.ConnectionString = global::ESHIFT.Properties.Settings.Default.eShiftDBConnectionString;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.SqlClient.SqlCommand[1];
            this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT UserName, Password, Role, idno FROM dbo.Login";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(eShiftDBDataSet1.LoginDataTable dataTable) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual eShiftDBDataSet1.LoginDataTable GetData() {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            eShiftDBDataSet1.LoginDataTable dataTable = new eShiftDBDataSet1.LoginDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(eShiftDBDataSet1.LoginDataTable dataTable) {
            return this.Adapter.Update(dataTable);
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(eShiftDBDataSet1 dataSet) {
            return this.Adapter.Update(dataSet, "Login");
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow) {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows) {
            return this.Adapter.Update(dataRows);
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(string Original_UserName, string Original_Password, string Original_Role, int Original_idno) {
            if ((Original_UserName == null)) {
                throw new global::System.ArgumentNullException("Original_UserName");
            }
            else {
                this.Adapter.DeleteCommand.Parameters[0].Value = ((string)(Original_UserName));
            }
            if ((Original_Password == null)) {
                throw new global::System.ArgumentNullException("Original_Password");
            }
            else {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((string)(Original_Password));
            }
            if ((Original_Role == null)) {
                this.Adapter.DeleteCommand.Parameters[2].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[2].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[3].Value = ((string)(Original_Role));
            }
            this.Adapter.DeleteCommand.Parameters[4].Value = ((int)(Original_idno));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string UserName, string Password, string Role) {
            if ((UserName == null)) {
                throw new global::System.ArgumentNullException("UserName");
            }
            else {
                this.Adapter.InsertCommand.Parameters[0].Value = ((string)(UserName));
            }
            if ((Password == null)) {
                throw new global::System.ArgumentNullException("Password");
            }
            else {
                this.Adapter.InsertCommand.Parameters[1].Value = ((string)(Password));
            }
            if ((Role == null)) {
                this.Adapter.InsertCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[2].Value = ((string)(Role));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string UserName, string Password, string Role, string Original_UserName, string Original_Password, string Original_Role, int Original_idno, int idno) {
            if ((UserName == null)) {
                throw new global::System.ArgumentNullException("UserName");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((string)(UserName));
            }
            if ((Password == null)) {
                throw new global::System.ArgumentNullException("Password");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((string)(Password));
            }
            if ((Role == null)) {
                this.Adapter.UpdateCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[2].Value = ((string)(Role));
            }
            if ((Original_UserName == null)) {
                throw new global::System.ArgumentNullException("Original_UserName");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((string)(Original_UserName));
            }
            if ((Original_Password == null)) {
                throw new global::System.ArgumentNullException("Original_Password");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((string)(Original_Password));
            }
            if ((Original_Role == null)) {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[6].Value = ((string)(Original_Role));
            }
            this.Adapter.UpdateCommand.Parameters[7].Value = ((int)(Original_idno));
            this.Adapter.UpdateCommand.Parameters[8].Value = ((int)(idno));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(string UserName, string Password, string Role, string Original_UserName, string Original_Password, string Original_Role, int Original_idno) {
            return this.Update(UserName, Password, Role, Original_UserName, Original_Password, Original_Role, Original_idno, Original_idno);
        }
    }
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class TempCusDTLTableAdapter : global::System.ComponentModel.Component {
        private global::System.Data.SqlClient.SqlDataAdapter _adapter;
        private global::System.Data.SqlClient.SqlConnection _connection;
        private global::System.Data.SqlClient.SqlTransaction _transaction;
        private global::System.Data.SqlClient.SqlCommand[] _commandCollection;
        private bool _clearBeforeFill;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public TempCusDTLTableAdapter() {
            this.ClearBeforeFill = true;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected internal global::System.Data.SqlClient.SqlDataAdapter Adapter {
            get {
                if ((this._adapter == null)) {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        internal global::System.Data.SqlClient.SqlConnection Connection {
            get {
                if ((this._connection == null)) {
                    this.InitConnection();
                }
                return this._connection;
            }
            set {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null)) {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null)) {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null)) {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    if ((this.CommandCollection[i] != null)) {
                        ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        internal global::System.Data.SqlClient.SqlTransaction Transaction {
            get {
                return this._transaction;
            }
            set {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.DeleteCommand != null))) {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.InsertCommand != null))) {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.UpdateCommand != null))) {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected global::System.Data.SqlClient.SqlCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public bool ClearBeforeFill {
            get {
                return this._clearBeforeFill;
            }
            set {
                this._clearBeforeFill = value;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitAdapter() {
            this._adapter = new global::System.Data.SqlClient.SqlDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "TempCusDTL";
            tableMapping.ColumnMappings.Add("TemporyCus_ID", "TemporyCus_ID");
            tableMapping.ColumnMappings.Add("Name", "Name");
            tableMapping.ColumnMappings.Add("NIC", "NIC");
            tableMapping.ColumnMappings.Add("phone", "phone");
            tableMapping.ColumnMappings.Add("Email", "Email");
            tableMapping.ColumnMappings.Add("Address", "Address");
            tableMapping.ColumnMappings.Add("Item", "Item");
            tableMapping.ColumnMappings.Add("Start_Location", "Start_Location");
            tableMapping.ColumnMappings.Add("Destination", "Destination");
            tableMapping.ColumnMappings.Add("Date", "Date");
            tableMapping.ColumnMappings.Add("Status", "Status");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = @"DELETE FROM [dbo].[TempCusDTL] WHERE (([TemporyCus_ID] = @Original_TemporyCus_ID) AND ([Name] = @Original_Name) AND ([NIC] = @Original_NIC) AND ([phone] = @Original_phone) AND ([Email] = @Original_Email) AND ([Address] = @Original_Address) AND ([Item] = @Original_Item) AND ([Start_Location] = @Original_Start_Location) AND ([Destination] = @Original_Destination) AND ([Date] = @Original_Date) AND ((@IsNull_Status = 1 AND [Status] IS NULL) OR ([Status] = @Original_Status)))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_TemporyCus_ID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "TemporyCus_ID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Name", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Name", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_NIC", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "NIC", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_phone", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "phone", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Email", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Email", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Address", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Address", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Item", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Item", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Start_Location", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Start_Location", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Destination", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Destination", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Date", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_Status", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Status", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Status", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Status", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.InsertCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = @"INSERT INTO [dbo].[TempCusDTL] ([Name], [NIC], [phone], [Email], [Address], [Item], [Start_Location], [Destination], [Date], [Status]) VALUES (@Name, @NIC, @phone, @Email, @Address, @Item, @Start_Location, @Destination, @Date, @Status);
SELECT TemporyCus_ID, Name, NIC, phone, Email, Address, Item, Start_Location, Destination, Date, Status FROM TempCusDTL WHERE (TemporyCus_ID = SCOPE_IDENTITY())";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Name", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Name", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@NIC", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "NIC", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@phone", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "phone", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Email", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Email", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Address", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Address", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Item", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Item", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Start_Location", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Start_Location", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Destination", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Destination", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Date", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Status", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Status", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = @"UPDATE [dbo].[TempCusDTL] SET [Name] = @Name, [NIC] = @NIC, [phone] = @phone, [Email] = @Email, [Address] = @Address, [Item] = @Item, [Start_Location] = @Start_Location, [Destination] = @Destination, [Date] = @Date, [Status] = @Status WHERE (([TemporyCus_ID] = @Original_TemporyCus_ID) AND ([Name] = @Original_Name) AND ([NIC] = @Original_NIC) AND ([phone] = @Original_phone) AND ([Email] = @Original_Email) AND ([Address] = @Original_Address) AND ([Item] = @Original_Item) AND ([Start_Location] = @Original_Start_Location) AND ([Destination] = @Original_Destination) AND ([Date] = @Original_Date) AND ((@IsNull_Status = 1 AND [Status] IS NULL) OR ([Status] = @Original_Status)));
SELECT TemporyCus_ID, Name, NIC, phone, Email, Address, Item, Start_Location, Destination, Date, Status FROM TempCusDTL WHERE (TemporyCus_ID = @TemporyCus_ID)";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Name", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Name", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@NIC", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "NIC", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@phone", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "phone", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Email", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Email", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Address", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Address", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Item", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Item", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Start_Location", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Start_Location", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Destination", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Destination", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Date", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Status", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Status", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_TemporyCus_ID", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "TemporyCus_ID", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Name", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Name", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_NIC", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "NIC", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_phone", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "phone", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Email", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Email", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Address", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Address", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Item", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Item", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Start_Location", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Start_Location", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Destination", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Destination", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Date", global::System.Data.SqlDbType.Date, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Date", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_Status", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Status", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Status", global::System.Data.SqlDbType.VarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "Status", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@TemporyCus_ID", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "TemporyCus_ID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitConnection() {
            this._connection = new global::System.Data.SqlClient.SqlConnection();
            this._connection.ConnectionString = global::ESHIFT.Properties.Settings.Default.eShiftDBConnectionString;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.SqlClient.SqlCommand[1];
            this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT TemporyCus_ID, Name, NIC, phone, Email, Address, Item, Start_Location, Des" +
                "tination, Date, Status FROM dbo.TempCusDTL";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(eShiftDBDataSet1.TempCusDTLDataTable dataTable) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual eShiftDBDataSet1.TempCusDTLDataTable GetData() {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            eShiftDBDataSet1.TempCusDTLDataTable dataTable = new eShiftDBDataSet1.TempCusDTLDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(eShiftDBDataSet1.TempCusDTLDataTable dataTable) {
            return this.Adapter.Update(dataTable);
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(eShiftDBDataSet1 dataSet) {
            return this.Adapter.Update(dataSet, "TempCusDTL");
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow) {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows) {
            return this.Adapter.Update(dataRows);
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int Original_TemporyCus_ID, string Original_Name, string Original_NIC, string Original_phone, string Original_Email, string Original_Address, string Original_Item, string Original_Start_Location, string Original_Destination, System.DateTime Original_Date, string Original_Status) {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(Original_TemporyCus_ID));
            if ((Original_Name == null)) {
                throw new global::System.ArgumentNullException("Original_Name");
            }
            else {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((string)(Original_Name));
            }
            if ((Original_NIC == null)) {
                throw new global::System.ArgumentNullException("Original_NIC");
            }
            else {
                this.Adapter.DeleteCommand.Parameters[2].Value = ((string)(Original_NIC));
            }
            if ((Original_phone == null)) {
                throw new global::System.ArgumentNullException("Original_phone");
            }
            else {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((string)(Original_phone));
            }
            if ((Original_Email == null)) {
                throw new global::System.ArgumentNullException("Original_Email");
            }
            else {
                this.Adapter.DeleteCommand.Parameters[4].Value = ((string)(Original_Email));
            }
            if ((Original_Address == null)) {
                throw new global::System.ArgumentNullException("Original_Address");
            }
            else {
                this.Adapter.DeleteCommand.Parameters[5].Value = ((string)(Original_Address));
            }
            if ((Original_Item == null)) {
                throw new global::System.ArgumentNullException("Original_Item");
            }
            else {
                this.Adapter.DeleteCommand.Parameters[6].Value = ((string)(Original_Item));
            }
            if ((Original_Start_Location == null)) {
                throw new global::System.ArgumentNullException("Original_Start_Location");
            }
            else {
                this.Adapter.DeleteCommand.Parameters[7].Value = ((string)(Original_Start_Location));
            }
            if ((Original_Destination == null)) {
                throw new global::System.ArgumentNullException("Original_Destination");
            }
            else {
                this.Adapter.DeleteCommand.Parameters[8].Value = ((string)(Original_Destination));
            }
            this.Adapter.DeleteCommand.Parameters[9].Value = ((System.DateTime)(Original_Date));
            if ((Original_Status == null)) {
                this.Adapter.DeleteCommand.Parameters[10].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[11].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[10].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[11].Value = ((string)(Original_Status));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string Name, string NIC, string phone, string Email, string Address, string Item, string Start_Location, string Destination, System.DateTime Date, string Status) {
            if ((Name == null)) {
                throw new global::System.ArgumentNullException("Name");
            }
            else {
                this.Adapter.InsertCommand.Parameters[0].Value = ((string)(Name));
            }
            if ((NIC == null)) {
                throw new global::System.ArgumentNullException("NIC");
            }
            else {
                this.Adapter.InsertCommand.Parameters[1].Value = ((string)(NIC));
            }
            if ((phone == null)) {
                throw new global::System.ArgumentNullException("phone");
            }
            else {
                this.Adapter.InsertCommand.Parameters[2].Value = ((string)(phone));
            }
            if ((Email == null)) {
                throw new global::System.ArgumentNullException("Email");
            }
            else {
                this.Adapter.InsertCommand.Parameters[3].Value = ((string)(Email));
            }
            if ((Address == null)) {
                throw new global::System.ArgumentNullException("Address");
            }
            else {
                this.Adapter.InsertCommand.Parameters[4].Value = ((string)(Address));
            }
            if ((Item == null)) {
                throw new global::System.ArgumentNullException("Item");
            }
            else {
                this.Adapter.InsertCommand.Parameters[5].Value = ((string)(Item));
            }
            if ((Start_Location == null)) {
                throw new global::System.ArgumentNullException("Start_Location");
            }
            else {
                this.Adapter.InsertCommand.Parameters[6].Value = ((string)(Start_Location));
            }
            if ((Destination == null)) {
                throw new global::System.ArgumentNullException("Destination");
            }
            else {
                this.Adapter.InsertCommand.Parameters[7].Value = ((string)(Destination));
            }
            this.Adapter.InsertCommand.Parameters[8].Value = ((System.DateTime)(Date));
            if ((Status == null)) {
                this.Adapter.InsertCommand.Parameters[9].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[9].Value = ((string)(Status));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(
                    string Name, 
                    string NIC, 
                    string phone, 
                    string Email, 
                    string Address, 
                    string Item, 
                    string Start_Location, 
                    string Destination, 
                    System.DateTime Date, 
                    string Status, 
                    int Original_TemporyCus_ID, 
                    string Original_Name, 
                    string Original_NIC, 
                    string Original_phone, 
                    string Original_Email, 
                    string Original_Address, 
                    string Original_Item, 
                    string Original_Start_Location, 
                    string Original_Destination, 
                    System.DateTime Original_Date, 
                    string Original_Status, 
                    int TemporyCus_ID) {
            if ((Name == null)) {
                throw new global::System.ArgumentNullException("Name");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((string)(Name));
            }
            if ((NIC == null)) {
                throw new global::System.ArgumentNullException("NIC");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((string)(NIC));
            }
            if ((phone == null)) {
                throw new global::System.ArgumentNullException("phone");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[2].Value = ((string)(phone));
            }
            if ((Email == null)) {
                throw new global::System.ArgumentNullException("Email");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((string)(Email));
            }
            if ((Address == null)) {
                throw new global::System.ArgumentNullException("Address");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((string)(Address));
            }
            if ((Item == null)) {
                throw new global::System.ArgumentNullException("Item");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((string)(Item));
            }
            if ((Start_Location == null)) {
                throw new global::System.ArgumentNullException("Start_Location");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((string)(Start_Location));
            }
            if ((Destination == null)) {
                throw new global::System.ArgumentNullException("Destination");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[7].Value = ((string)(Destination));
            }
            this.Adapter.UpdateCommand.Parameters[8].Value = ((System.DateTime)(Date));
            if ((Status == null)) {
                this.Adapter.UpdateCommand.Parameters[9].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[9].Value = ((string)(Status));
            }
            this.Adapter.UpdateCommand.Parameters[10].Value = ((int)(Original_TemporyCus_ID));
            if ((Original_Name == null)) {
                throw new global::System.ArgumentNullException("Original_Name");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[11].Value = ((string)(Original_Name));
            }
            if ((Original_NIC == null)) {
                throw new global::System.ArgumentNullException("Original_NIC");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[12].Value = ((string)(Original_NIC));
            }
            if ((Original_phone == null)) {
                throw new global::System.ArgumentNullException("Original_phone");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[13].Value = ((string)(Original_phone));
            }
            if ((Original_Email == null)) {
                throw new global::System.ArgumentNullException("Original_Email");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[14].Value = ((string)(Original_Email));
            }
            if ((Original_Address == null)) {
                throw new global::System.ArgumentNullException("Original_Address");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[15].Value = ((string)(Original_Address));
            }
            if ((Original_Item == null)) {
                throw new global::System.ArgumentNullException("Original_Item");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[16].Value = ((string)(Original_Item));
            }
            if ((Original_Start_Location == null)) {
                throw new global::System.ArgumentNullException("Original_Start_Location");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[17].Value = ((string)(Original_Start_Location));
            }
            if ((Original_Destination == null)) {
                throw new global::System.ArgumentNullException("Original_Destination");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[18].Value = ((string)(Original_Destination));
            }
            this.Adapter.UpdateCommand.Parameters[19].Value = ((System.DateTime)(Original_Date));
            if ((Original_Status == null)) {
                this.Adapter.UpdateCommand.Parameters[20].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[21].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[20].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[21].Value = ((string)(Original_Status));
            }
            this.Adapter.UpdateCommand.Parameters[22].Value = ((int)(TemporyCus_ID));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(
                    string Name, 
                    string NIC, 
                    string phone, 
                    string Email, 
                    string Address, 
                    string Item, 
                    string Start_Location, 
                    string Destination, 
                    System.DateTime Date, 
                    string Status, 
                    int Original_TemporyCus_ID, 
                    string Original_Name, 
                    string Original_NIC, 
                    string Original_phone, 
                    string Original_Email, 
                    string Original_Address, 
                    string Original_Item, 
                    string Original_Start_Location, 
                    string Original_Destination, 
                    System.DateTime Original_Date, 
                    string Original_Status) {
            return this.Update(Name, NIC, phone, Email, Address, Item, Start_Location, Destination, Date, Status, Original_TemporyCus_ID, Original_Name, Original_NIC, Original_phone, Original_Email, Original_Address, Original_Item, Original_Start_Location, Original_Destination, Original_Date, Original_Status, Original_TemporyCus_ID);
        }
    }
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class TransportUnitTableAdapter : global::System.ComponentModel.Component {
        private global::System.Data.SqlClient.SqlDataAdapter _adapter;
        private global::System.Data.SqlClient.SqlConnection _connection;
        private global::System.Data.SqlClient.SqlTransaction _transaction;
        private global::System.Data.SqlClient.SqlCommand[] _commandCollection;
        private bool _clearBeforeFill;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public TransportUnitTableAdapter() {
            this.ClearBeforeFill = true;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected internal global::System.Data.SqlClient.SqlDataAdapter Adapter {
            get {
                if ((this._adapter == null)) {
                    this.InitAdapter();
                }
                return this._adapter;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        internal global::System.Data.SqlClient.SqlConnection Connection {
            get {
                if ((this._connection == null)) {
                    this.InitConnection();
                }
                return this._connection;
            }
            set {
                this._connection = value;
                if ((this.Adapter.InsertCommand != null)) {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if ((this.Adapter.DeleteCommand != null)) {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if ((this.Adapter.UpdateCommand != null)) {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    if ((this.CommandCollection[i] != null)) {
                        ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        internal global::System.Data.SqlClient.SqlTransaction Transaction {
            get {
                return this._transaction;
            }
            set {
                this._transaction = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1)) {
                    this.CommandCollection[i].Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.DeleteCommand != null))) {
                    this.Adapter.DeleteCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.InsertCommand != null))) {
                    this.Adapter.InsertCommand.Transaction = this._transaction;
                }
                if (((this.Adapter != null) 
                            && (this.Adapter.UpdateCommand != null))) {
                    this.Adapter.UpdateCommand.Transaction = this._transaction;
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected global::System.Data.SqlClient.SqlCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public bool ClearBeforeFill {
            get {
                return this._clearBeforeFill;
            }
            set {
                this._clearBeforeFill = value;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitAdapter() {
            this._adapter = new global::System.Data.SqlClient.SqlDataAdapter();
            global::System.Data.Common.DataTableMapping tableMapping = new global::System.Data.Common.DataTableMapping();
            tableMapping.SourceTable = "Table";
            tableMapping.DataSetTable = "TransportUnit";
            tableMapping.ColumnMappings.Add("UnitId", "UnitId");
            tableMapping.ColumnMappings.Add("VehicleNumberPlate", "VehicleNumberPlate");
            tableMapping.ColumnMappings.Add("DriverName", "DriverName");
            tableMapping.ColumnMappings.Add("DriverPhone", "DriverPhone");
            tableMapping.ColumnMappings.Add("DriverIdNo", "DriverIdNo");
            tableMapping.ColumnMappings.Add("AssistantName", "AssistantName");
            tableMapping.ColumnMappings.Add("AssistantPhone", "AssistantPhone");
            tableMapping.ColumnMappings.Add("AssistantIdNo", "AssistantIdNo");
            tableMapping.ColumnMappings.Add("ContainerId", "ContainerId");
            this._adapter.TableMappings.Add(tableMapping);
            this._adapter.DeleteCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.DeleteCommand.Connection = this.Connection;
            this._adapter.DeleteCommand.CommandText = @"DELETE FROM [dbo].[TransportUnit] WHERE (([UnitId] = @Original_UnitId) AND ([VehicleNumberPlate] = @Original_VehicleNumberPlate) AND ([DriverName] = @Original_DriverName) AND ((@IsNull_DriverPhone = 1 AND [DriverPhone] IS NULL) OR ([DriverPhone] = @Original_DriverPhone)) AND ((@IsNull_DriverIdNo = 1 AND [DriverIdNo] IS NULL) OR ([DriverIdNo] = @Original_DriverIdNo)) AND ((@IsNull_AssistantName = 1 AND [AssistantName] IS NULL) OR ([AssistantName] = @Original_AssistantName)) AND ((@IsNull_AssistantPhone = 1 AND [AssistantPhone] IS NULL) OR ([AssistantPhone] = @Original_AssistantPhone)) AND ((@IsNull_AssistantIdNo = 1 AND [AssistantIdNo] IS NULL) OR ([AssistantIdNo] = @Original_AssistantIdNo)) AND ((@IsNull_ContainerId = 1 AND [ContainerId] IS NULL) OR ([ContainerId] = @Original_ContainerId)))";
            this._adapter.DeleteCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_UnitId", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "UnitId", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_VehicleNumberPlate", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "VehicleNumberPlate", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_DriverName", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DriverName", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_DriverPhone", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DriverPhone", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_DriverPhone", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DriverPhone", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_DriverIdNo", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DriverIdNo", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_DriverIdNo", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DriverIdNo", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_AssistantName", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "AssistantName", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_AssistantName", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "AssistantName", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_AssistantPhone", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "AssistantPhone", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_AssistantPhone", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "AssistantPhone", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_AssistantIdNo", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "AssistantIdNo", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_AssistantIdNo", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "AssistantIdNo", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_ContainerId", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "ContainerId", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.DeleteCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_ContainerId", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "ContainerId", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.InsertCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.InsertCommand.Connection = this.Connection;
            this._adapter.InsertCommand.CommandText = @"INSERT INTO [dbo].[TransportUnit] ([VehicleNumberPlate], [DriverName], [DriverPhone], [DriverIdNo], [AssistantName], [AssistantPhone], [AssistantIdNo], [ContainerId]) VALUES (@VehicleNumberPlate, @DriverName, @DriverPhone, @DriverIdNo, @AssistantName, @AssistantPhone, @AssistantIdNo, @ContainerId);
SELECT UnitId, VehicleNumberPlate, DriverName, DriverPhone, DriverIdNo, AssistantName, AssistantPhone, AssistantIdNo, ContainerId FROM TransportUnit WHERE (UnitId = SCOPE_IDENTITY())";
            this._adapter.InsertCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@VehicleNumberPlate", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "VehicleNumberPlate", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@DriverName", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DriverName", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@DriverPhone", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DriverPhone", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@DriverIdNo", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DriverIdNo", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@AssistantName", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "AssistantName", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@AssistantPhone", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "AssistantPhone", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@AssistantIdNo", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "AssistantIdNo", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.InsertCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@ContainerId", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "ContainerId", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand = new global::System.Data.SqlClient.SqlCommand();
            this._adapter.UpdateCommand.Connection = this.Connection;
            this._adapter.UpdateCommand.CommandText = @"UPDATE [dbo].[TransportUnit] SET [VehicleNumberPlate] = @VehicleNumberPlate, [DriverName] = @DriverName, [DriverPhone] = @DriverPhone, [DriverIdNo] = @DriverIdNo, [AssistantName] = @AssistantName, [AssistantPhone] = @AssistantPhone, [AssistantIdNo] = @AssistantIdNo, [ContainerId] = @ContainerId WHERE (([UnitId] = @Original_UnitId) AND ([VehicleNumberPlate] = @Original_VehicleNumberPlate) AND ([DriverName] = @Original_DriverName) AND ((@IsNull_DriverPhone = 1 AND [DriverPhone] IS NULL) OR ([DriverPhone] = @Original_DriverPhone)) AND ((@IsNull_DriverIdNo = 1 AND [DriverIdNo] IS NULL) OR ([DriverIdNo] = @Original_DriverIdNo)) AND ((@IsNull_AssistantName = 1 AND [AssistantName] IS NULL) OR ([AssistantName] = @Original_AssistantName)) AND ((@IsNull_AssistantPhone = 1 AND [AssistantPhone] IS NULL) OR ([AssistantPhone] = @Original_AssistantPhone)) AND ((@IsNull_AssistantIdNo = 1 AND [AssistantIdNo] IS NULL) OR ([AssistantIdNo] = @Original_AssistantIdNo)) AND ((@IsNull_ContainerId = 1 AND [ContainerId] IS NULL) OR ([ContainerId] = @Original_ContainerId)));
SELECT UnitId, VehicleNumberPlate, DriverName, DriverPhone, DriverIdNo, AssistantName, AssistantPhone, AssistantIdNo, ContainerId FROM TransportUnit WHERE (UnitId = @UnitId)";
            this._adapter.UpdateCommand.CommandType = global::System.Data.CommandType.Text;
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@VehicleNumberPlate", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "VehicleNumberPlate", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@DriverName", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DriverName", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@DriverPhone", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DriverPhone", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@DriverIdNo", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DriverIdNo", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@AssistantName", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "AssistantName", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@AssistantPhone", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "AssistantPhone", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@AssistantIdNo", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "AssistantIdNo", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@ContainerId", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "ContainerId", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_UnitId", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "UnitId", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_VehicleNumberPlate", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "VehicleNumberPlate", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_DriverName", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DriverName", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_DriverPhone", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DriverPhone", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_DriverPhone", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DriverPhone", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_DriverIdNo", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DriverIdNo", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_DriverIdNo", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "DriverIdNo", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_AssistantName", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "AssistantName", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_AssistantName", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "AssistantName", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_AssistantPhone", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "AssistantPhone", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_AssistantPhone", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "AssistantPhone", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_AssistantIdNo", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "AssistantIdNo", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_AssistantIdNo", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "AssistantIdNo", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsNull_ContainerId", global::System.Data.SqlDbType.Int, 0, global::System.Data.ParameterDirection.Input, 0, 0, "ContainerId", global::System.Data.DataRowVersion.Original, true, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_ContainerId", global::System.Data.SqlDbType.NVarChar, 0, global::System.Data.ParameterDirection.Input, 0, 0, "ContainerId", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._adapter.UpdateCommand.Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@UnitId", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "UnitId", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitConnection() {
            this._connection = new global::System.Data.SqlClient.SqlConnection();
            this._connection.ConnectionString = global::ESHIFT.Properties.Settings.Default.eShiftDBConnectionString;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.SqlClient.SqlCommand[1];
            this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT UnitId, VehicleNumberPlate, DriverName, DriverPhone, DriverIdNo, Assistant" +
                "Name, AssistantPhone, AssistantIdNo, ContainerId FROM dbo.TransportUnit";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, true)]
        public virtual int Fill(eShiftDBDataSet1.TransportUnitDataTable dataTable) {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if ((this.ClearBeforeFill == true)) {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, true)]
        public virtual eShiftDBDataSet1.TransportUnitDataTable GetData() {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            eShiftDBDataSet1.TransportUnitDataTable dataTable = new eShiftDBDataSet1.TransportUnitDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(eShiftDBDataSet1.TransportUnitDataTable dataTable) {
            return this.Adapter.Update(dataTable);
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(eShiftDBDataSet1 dataSet) {
            return this.Adapter.Update(dataSet, "TransportUnit");
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow dataRow) {
            return this.Adapter.Update(new global::System.Data.DataRow[] {
                        dataRow});
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int Update(global::System.Data.DataRow[] dataRows) {
            return this.Adapter.Update(dataRows);
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(int Original_UnitId, string Original_VehicleNumberPlate, string Original_DriverName, string Original_DriverPhone, string Original_DriverIdNo, string Original_AssistantName, string Original_AssistantPhone, string Original_AssistantIdNo, string Original_ContainerId) {
            this.Adapter.DeleteCommand.Parameters[0].Value = ((int)(Original_UnitId));
            if ((Original_VehicleNumberPlate == null)) {
                throw new global::System.ArgumentNullException("Original_VehicleNumberPlate");
            }
            else {
                this.Adapter.DeleteCommand.Parameters[1].Value = ((string)(Original_VehicleNumberPlate));
            }
            if ((Original_DriverName == null)) {
                throw new global::System.ArgumentNullException("Original_DriverName");
            }
            else {
                this.Adapter.DeleteCommand.Parameters[2].Value = ((string)(Original_DriverName));
            }
            if ((Original_DriverPhone == null)) {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[3].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[4].Value = ((string)(Original_DriverPhone));
            }
            if ((Original_DriverIdNo == null)) {
                this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[5].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[6].Value = ((string)(Original_DriverIdNo));
            }
            if ((Original_AssistantName == null)) {
                this.Adapter.DeleteCommand.Parameters[7].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[8].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[7].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[8].Value = ((string)(Original_AssistantName));
            }
            if ((Original_AssistantPhone == null)) {
                this.Adapter.DeleteCommand.Parameters[9].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[10].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[9].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[10].Value = ((string)(Original_AssistantPhone));
            }
            if ((Original_AssistantIdNo == null)) {
                this.Adapter.DeleteCommand.Parameters[11].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[12].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[11].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[12].Value = ((string)(Original_AssistantIdNo));
            }
            if ((Original_ContainerId == null)) {
                this.Adapter.DeleteCommand.Parameters[13].Value = ((object)(1));
                this.Adapter.DeleteCommand.Parameters[14].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.DeleteCommand.Parameters[13].Value = ((object)(0));
                this.Adapter.DeleteCommand.Parameters[14].Value = ((string)(Original_ContainerId));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
            if (((this.Adapter.DeleteCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.DeleteCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(string VehicleNumberPlate, string DriverName, string DriverPhone, string DriverIdNo, string AssistantName, string AssistantPhone, string AssistantIdNo, string ContainerId) {
            if ((VehicleNumberPlate == null)) {
                throw new global::System.ArgumentNullException("VehicleNumberPlate");
            }
            else {
                this.Adapter.InsertCommand.Parameters[0].Value = ((string)(VehicleNumberPlate));
            }
            if ((DriverName == null)) {
                throw new global::System.ArgumentNullException("DriverName");
            }
            else {
                this.Adapter.InsertCommand.Parameters[1].Value = ((string)(DriverName));
            }
            if ((DriverPhone == null)) {
                this.Adapter.InsertCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[2].Value = ((string)(DriverPhone));
            }
            if ((DriverIdNo == null)) {
                this.Adapter.InsertCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[3].Value = ((string)(DriverIdNo));
            }
            if ((AssistantName == null)) {
                this.Adapter.InsertCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[4].Value = ((string)(AssistantName));
            }
            if ((AssistantPhone == null)) {
                this.Adapter.InsertCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[5].Value = ((string)(AssistantPhone));
            }
            if ((AssistantIdNo == null)) {
                this.Adapter.InsertCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[6].Value = ((string)(AssistantIdNo));
            }
            if ((ContainerId == null)) {
                this.Adapter.InsertCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.InsertCommand.Parameters[7].Value = ((string)(ContainerId));
            }
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
            if (((this.Adapter.InsertCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(
                    string VehicleNumberPlate, 
                    string DriverName, 
                    string DriverPhone, 
                    string DriverIdNo, 
                    string AssistantName, 
                    string AssistantPhone, 
                    string AssistantIdNo, 
                    string ContainerId, 
                    int Original_UnitId, 
                    string Original_VehicleNumberPlate, 
                    string Original_DriverName, 
                    string Original_DriverPhone, 
                    string Original_DriverIdNo, 
                    string Original_AssistantName, 
                    string Original_AssistantPhone, 
                    string Original_AssistantIdNo, 
                    string Original_ContainerId, 
                    int UnitId) {
            if ((VehicleNumberPlate == null)) {
                throw new global::System.ArgumentNullException("VehicleNumberPlate");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[0].Value = ((string)(VehicleNumberPlate));
            }
            if ((DriverName == null)) {
                throw new global::System.ArgumentNullException("DriverName");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[1].Value = ((string)(DriverName));
            }
            if ((DriverPhone == null)) {
                this.Adapter.UpdateCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[2].Value = ((string)(DriverPhone));
            }
            if ((DriverIdNo == null)) {
                this.Adapter.UpdateCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[3].Value = ((string)(DriverIdNo));
            }
            if ((AssistantName == null)) {
                this.Adapter.UpdateCommand.Parameters[4].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[4].Value = ((string)(AssistantName));
            }
            if ((AssistantPhone == null)) {
                this.Adapter.UpdateCommand.Parameters[5].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[5].Value = ((string)(AssistantPhone));
            }
            if ((AssistantIdNo == null)) {
                this.Adapter.UpdateCommand.Parameters[6].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[6].Value = ((string)(AssistantIdNo));
            }
            if ((ContainerId == null)) {
                this.Adapter.UpdateCommand.Parameters[7].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[7].Value = ((string)(ContainerId));
            }
            this.Adapter.UpdateCommand.Parameters[8].Value = ((int)(Original_UnitId));
            if ((Original_VehicleNumberPlate == null)) {
                throw new global::System.ArgumentNullException("Original_VehicleNumberPlate");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[9].Value = ((string)(Original_VehicleNumberPlate));
            }
            if ((Original_DriverName == null)) {
                throw new global::System.ArgumentNullException("Original_DriverName");
            }
            else {
                this.Adapter.UpdateCommand.Parameters[10].Value = ((string)(Original_DriverName));
            }
            if ((Original_DriverPhone == null)) {
                this.Adapter.UpdateCommand.Parameters[11].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[12].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[11].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[12].Value = ((string)(Original_DriverPhone));
            }
            if ((Original_DriverIdNo == null)) {
                this.Adapter.UpdateCommand.Parameters[13].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[14].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[13].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[14].Value = ((string)(Original_DriverIdNo));
            }
            if ((Original_AssistantName == null)) {
                this.Adapter.UpdateCommand.Parameters[15].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[16].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[15].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[16].Value = ((string)(Original_AssistantName));
            }
            if ((Original_AssistantPhone == null)) {
                this.Adapter.UpdateCommand.Parameters[17].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[18].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[17].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[18].Value = ((string)(Original_AssistantPhone));
            }
            if ((Original_AssistantIdNo == null)) {
                this.Adapter.UpdateCommand.Parameters[19].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[20].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[19].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[20].Value = ((string)(Original_AssistantIdNo));
            }
            if ((Original_ContainerId == null)) {
                this.Adapter.UpdateCommand.Parameters[21].Value = ((object)(1));
                this.Adapter.UpdateCommand.Parameters[22].Value = global::System.DBNull.Value;
            }
            else {
                this.Adapter.UpdateCommand.Parameters[21].Value = ((object)(0));
                this.Adapter.UpdateCommand.Parameters[22].Value = ((string)(Original_ContainerId));
            }
            this.Adapter.UpdateCommand.Parameters[23].Value = ((int)(UnitId));
            global::System.Data.ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
            if (((this.Adapter.UpdateCommand.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try {
                int returnValue = this.Adapter.UpdateCommand.ExecuteNonQuery();
                return returnValue;
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(
                    string VehicleNumberPlate, 
                    string DriverName, 
                    string DriverPhone, 
                    string DriverIdNo, 
                    string AssistantName, 
                    string AssistantPhone, 
                    string AssistantIdNo, 
                    string ContainerId, 
                    int Original_UnitId, 
                    string Original_VehicleNumberPlate, 
                    string Original_DriverName, 
                    string Original_DriverPhone, 
                    string Original_DriverIdNo, 
                    string Original_AssistantName, 
                    string Original_AssistantPhone, 
                    string Original_AssistantIdNo, 
                    string Original_ContainerId) {
            return this.Update(VehicleNumberPlate, DriverName, DriverPhone, DriverIdNo, AssistantName, AssistantPhone, AssistantIdNo, ContainerId, Original_UnitId, Original_VehicleNumberPlate, Original_DriverName, Original_DriverPhone, Original_DriverIdNo, Original_AssistantName, Original_AssistantPhone, Original_AssistantIdNo, Original_ContainerId, Original_UnitId);
        }
    }
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSD" +
        "esigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapterManager")]
    public partial class TableAdapterManager : global::System.ComponentModel.Component {
        private UpdateOrderOption _updateOrder;
        private CustomerTableAdapter _customerTableAdapter;
        private JobTableAdapter _jobTableAdapter;
        private LoadTableAdapter _loadTableAdapter;
        private LoginTableAdapter _loginTableAdapter;
        private TempCusDTLTableAdapter _tempCusDTLTableAdapter;
        private TransportUnitTableAdapter _transportUnitTableAdapter;
        private bool _backupDataSetBeforeUpdate;
        private global::System.Data.IDbConnection _connection;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public UpdateOrderOption UpdateOrder {
            get {
                return this._updateOrder;
            }
            set {
                this._updateOrder = value;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public CustomerTableAdapter CustomerTableAdapter {
            get {
                return this._customerTableAdapter;
            }
            set {
                this._customerTableAdapter = value;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public JobTableAdapter JobTableAdapter {
            get {
                return this._jobTableAdapter;
            }
            set {
                this._jobTableAdapter = value;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public LoadTableAdapter LoadTableAdapter {
            get {
                return this._loadTableAdapter;
            }
            set {
                this._loadTableAdapter = value;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public LoginTableAdapter LoginTableAdapter {
            get {
                return this._loginTableAdapter;
            }
            set {
                this._loginTableAdapter = value;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public TempCusDTLTableAdapter TempCusDTLTableAdapter {
            get {
                return this._tempCusDTLTableAdapter;
            }
            set {
                this._tempCusDTLTableAdapter = value;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public TransportUnitTableAdapter TransportUnitTableAdapter {
            get {
                return this._transportUnitTableAdapter;
            }
            set {
                this._transportUnitTableAdapter = value;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public bool BackupDataSetBeforeUpdate {
            get {
                return this._backupDataSetBeforeUpdate;
            }
            set {
                this._backupDataSetBeforeUpdate = value;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        public global::System.Data.IDbConnection Connection {
            get {
                if ((this._connection != null)) {
                    return this._connection;
                }
                if (((this._customerTableAdapter != null) 
                            && (this._customerTableAdapter.Connection != null))) {
                    return this._customerTableAdapter.Connection;
                }
                if (((this._jobTableAdapter != null) 
                            && (this._jobTableAdapter.Connection != null))) {
                    return this._jobTableAdapter.Connection;
                }
                if (((this._loadTableAdapter != null) 
                            && (this._loadTableAdapter.Connection != null))) {
                    return this._loadTableAdapter.Connection;
                }
                if (((this._loginTableAdapter != null) 
                            && (this._loginTableAdapter.Connection != null))) {
                    return this._loginTableAdapter.Connection;
                }
                if (((this._tempCusDTLTableAdapter != null) 
                            && (this._tempCusDTLTableAdapter.Connection != null))) {
                    return this._tempCusDTLTableAdapter.Connection;
                }
                if (((this._transportUnitTableAdapter != null) 
                            && (this._transportUnitTableAdapter.Connection != null))) {
                    return this._transportUnitTableAdapter.Connection;
                }
                return null;
            }
            set {
                this._connection = value;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        public int TableAdapterInstanceCount {
            get {
                int count = 0;
                if ((this._customerTableAdapter != null)) {
                    count = (count + 1);
                }
                if ((this._jobTableAdapter != null)) {
                    count = (count + 1);
                }
                if ((this._loadTableAdapter != null)) {
                    count = (count + 1);
                }
                if ((this._loginTableAdapter != null)) {
                    count = (count + 1);
                }
                if ((this._tempCusDTLTableAdapter != null)) {
                    count = (count + 1);
                }
                if ((this._transportUnitTableAdapter != null)) {
                    count = (count + 1);
                }
                return count;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private int UpdateUpdatedRows(eShiftDBDataSet1 dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows) {
            int result = 0;
            if ((this._customerTableAdapter != null)) {
                global::System.Data.DataRow[] updatedRows = dataSet.Customer.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null) 
                            && (0 < updatedRows.Length))) {
                    result = (result + this._customerTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if ((this._jobTableAdapter != null)) {
                global::System.Data.DataRow[] updatedRows = dataSet.Job.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null) 
                            && (0 < updatedRows.Length))) {
                    result = (result + this._jobTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if ((this._transportUnitTableAdapter != null)) {
                global::System.Data.DataRow[] updatedRows = dataSet.TransportUnit.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null) 
                            && (0 < updatedRows.Length))) {
                    result = (result + this._transportUnitTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if ((this._loadTableAdapter != null)) {
                global::System.Data.DataRow[] updatedRows = dataSet.Load.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null) 
                            && (0 < updatedRows.Length))) {
                    result = (result + this._loadTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if ((this._loginTableAdapter != null)) {
                global::System.Data.DataRow[] updatedRows = dataSet.Login.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null) 
                            && (0 < updatedRows.Length))) {
                    result = (result + this._loginTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if ((this._tempCusDTLTableAdapter != null)) {
                global::System.Data.DataRow[] updatedRows = dataSet.TempCusDTL.Select(null, null, global::System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if (((updatedRows != null) 
                            && (0 < updatedRows.Length))) {
                    result = (result + this._tempCusDTLTableAdapter.Update(updatedRows));
                    allChangedRows.AddRange(updatedRows);
                }
            }
            return result;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private int UpdateInsertedRows(eShiftDBDataSet1 dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows) {
            int result = 0;
            if ((this._customerTableAdapter != null)) {
                global::System.Data.DataRow[] addedRows = dataSet.Customer.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null) 
                            && (0 < addedRows.Length))) {
                    result = (result + this._customerTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            if ((this._jobTableAdapter != null)) {
                global::System.Data.DataRow[] addedRows = dataSet.Job.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null) 
                            && (0 < addedRows.Length))) {
                    result = (result + this._jobTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            if ((this._transportUnitTableAdapter != null)) {
                global::System.Data.DataRow[] addedRows = dataSet.TransportUnit.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null) 
                            && (0 < addedRows.Length))) {
                    result = (result + this._transportUnitTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            if ((this._loadTableAdapter != null)) {
                global::System.Data.DataRow[] addedRows = dataSet.Load.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null) 
                            && (0 < addedRows.Length))) {
                    result = (result + this._loadTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            if ((this._loginTableAdapter != null)) {
                global::System.Data.DataRow[] addedRows = dataSet.Login.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null) 
                            && (0 < addedRows.Length))) {
                    result = (result + this._loginTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            if ((this._tempCusDTLTableAdapter != null)) {
                global::System.Data.DataRow[] addedRows = dataSet.TempCusDTL.Select(null, null, global::System.Data.DataViewRowState.Added);
                if (((addedRows != null) 
                            && (0 < addedRows.Length))) {
                    result = (result + this._tempCusDTLTableAdapter.Update(addedRows));
                    allAddedRows.AddRange(addedRows);
                }
            }
            return result;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private int UpdateDeletedRows(eShiftDBDataSet1 dataSet, global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows) {
            int result = 0;
            if ((this._tempCusDTLTableAdapter != null)) {
                global::System.Data.DataRow[] deletedRows = dataSet.TempCusDTL.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null) 
                            && (0 < deletedRows.Length))) {
                    result = (result + this._tempCusDTLTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            if ((this._loginTableAdapter != null)) {
                global::System.Data.DataRow[] deletedRows = dataSet.Login.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null) 
                            && (0 < deletedRows.Length))) {
                    result = (result + this._loginTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            if ((this._loadTableAdapter != null)) {
                global::System.Data.DataRow[] deletedRows = dataSet.Load.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null) 
                            && (0 < deletedRows.Length))) {
                    result = (result + this._loadTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            if ((this._transportUnitTableAdapter != null)) {
                global::System.Data.DataRow[] deletedRows = dataSet.TransportUnit.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null) 
                            && (0 < deletedRows.Length))) {
                    result = (result + this._transportUnitTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            if ((this._jobTableAdapter != null)) {
                global::System.Data.DataRow[] deletedRows = dataSet.Job.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null) 
                            && (0 < deletedRows.Length))) {
                    result = (result + this._jobTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            if ((this._customerTableAdapter != null)) {
                global::System.Data.DataRow[] deletedRows = dataSet.Customer.Select(null, null, global::System.Data.DataViewRowState.Deleted);
                if (((deletedRows != null) 
                            && (0 < deletedRows.Length))) {
                    result = (result + this._customerTableAdapter.Update(deletedRows));
                    allChangedRows.AddRange(deletedRows);
                }
            }
            return result;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private global::System.Data.DataRow[] GetRealUpdatedRows(global::System.Data.DataRow[] updatedRows, global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows) {
            if (((updatedRows == null) 
                        || (updatedRows.Length < 1))) {
                return updatedRows;
            }
            if (((allAddedRows == null) 
                        || (allAddedRows.Count < 1))) {
                return updatedRows;
            }
            global::System.Collections.Generic.List<global::System.Data.DataRow> realUpdatedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
            for (int i = 0; (i < updatedRows.Length); i = (i + 1)) {
                global::System.Data.DataRow row = updatedRows[i];
                if ((allAddedRows.Contains(row) == false)) {
                    realUpdatedRows.Add(row);
                }
            }
            return realUpdatedRows.ToArray();
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public virtual int UpdateAll(eShiftDBDataSet1 dataSet) {
            if ((dataSet == null)) {
                throw new global::System.ArgumentNullException("dataSet");
            }
            if ((dataSet.HasChanges() == false)) {
                return 0;
            }
            if (((this._customerTableAdapter != null) 
                        && (this.MatchTableAdapterConnection(this._customerTableAdapter.Connection) == false))) {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            if (((this._jobTableAdapter != null) 
                        && (this.MatchTableAdapterConnection(this._jobTableAdapter.Connection) == false))) {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            if (((this._loadTableAdapter != null) 
                        && (this.MatchTableAdapterConnection(this._loadTableAdapter.Connection) == false))) {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            if (((this._loginTableAdapter != null) 
                        && (this.MatchTableAdapterConnection(this._loginTableAdapter.Connection) == false))) {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            if (((this._tempCusDTLTableAdapter != null) 
                        && (this.MatchTableAdapterConnection(this._tempCusDTLTableAdapter.Connection) == false))) {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            if (((this._transportUnitTableAdapter != null) 
                        && (this.MatchTableAdapterConnection(this._transportUnitTableAdapter.Connection) == false))) {
                throw new global::System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            global::System.Data.IDbConnection workConnection = this.Connection;
            if ((workConnection == null)) {
                throw new global::System.ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterMana" +
                        "ger TableAdapter property to a valid TableAdapter instance.");
            }
            bool workConnOpened = false;
            if (((workConnection.State & global::System.Data.ConnectionState.Broken) 
                        == global::System.Data.ConnectionState.Broken)) {
                workConnection.Close();
            }
            if ((workConnection.State == global::System.Data.ConnectionState.Closed)) {
                workConnection.Open();
                workConnOpened = true;
            }
            global::System.Data.IDbTransaction workTransaction = workConnection.BeginTransaction();
            if ((workTransaction == null)) {
                throw new global::System.ApplicationException("The transaction cannot begin. The current data connection does not support transa" +
                        "ctions or the current state is not allowing the transaction to begin.");
            }
            global::System.Collections.Generic.List<global::System.Data.DataRow> allChangedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
            global::System.Collections.Generic.List<global::System.Data.DataRow> allAddedRows = new global::System.Collections.Generic.List<global::System.Data.DataRow>();
            global::System.Collections.Generic.List<global::System.Data.Common.DataAdapter> adaptersWithAcceptChangesDuringUpdate = new global::System.Collections.Generic.List<global::System.Data.Common.DataAdapter>();
            global::System.Collections.Generic.Dictionary<object, global::System.Data.IDbConnection> revertConnections = new global::System.Collections.Generic.Dictionary<object, global::System.Data.IDbConnection>();
            int result = 0;
            global::System.Data.DataSet backupDataSet = null;
            if (this.BackupDataSetBeforeUpdate) {
                backupDataSet = new global::System.Data.DataSet();
                backupDataSet.Merge(dataSet);
            }
            try {
                if ((this._customerTableAdapter != null)) {
                    revertConnections.Add(this._customerTableAdapter, this._customerTableAdapter.Connection);
                    this._customerTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(workConnection));
                    this._customerTableAdapter.Transaction = ((global::System.Data.SqlClient.SqlTransaction)(workTransaction));
                    if (this._customerTableAdapter.Adapter.AcceptChangesDuringUpdate) {
                        this._customerTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._customerTableAdapter.Adapter);
                    }
                }
                if ((this._jobTableAdapter != null)) {
                    revertConnections.Add(this._jobTableAdapter, this._jobTableAdapter.Connection);
                    this._jobTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(workConnection));
                    this._jobTableAdapter.Transaction = ((global::System.Data.SqlClient.SqlTransaction)(workTransaction));
                    if (this._jobTableAdapter.Adapter.AcceptChangesDuringUpdate) {
                        this._jobTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._jobTableAdapter.Adapter);
                    }
                }
                if ((this._loadTableAdapter != null)) {
                    revertConnections.Add(this._loadTableAdapter, this._loadTableAdapter.Connection);
                    this._loadTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(workConnection));
                    this._loadTableAdapter.Transaction = ((global::System.Data.SqlClient.SqlTransaction)(workTransaction));
                    if (this._loadTableAdapter.Adapter.AcceptChangesDuringUpdate) {
                        this._loadTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._loadTableAdapter.Adapter);
                    }
                }
                if ((this._loginTableAdapter != null)) {
                    revertConnections.Add(this._loginTableAdapter, this._loginTableAdapter.Connection);
                    this._loginTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(workConnection));
                    this._loginTableAdapter.Transaction = ((global::System.Data.SqlClient.SqlTransaction)(workTransaction));
                    if (this._loginTableAdapter.Adapter.AcceptChangesDuringUpdate) {
                        this._loginTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._loginTableAdapter.Adapter);
                    }
                }
                if ((this._tempCusDTLTableAdapter != null)) {
                    revertConnections.Add(this._tempCusDTLTableAdapter, this._tempCusDTLTableAdapter.Connection);
                    this._tempCusDTLTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(workConnection));
                    this._tempCusDTLTableAdapter.Transaction = ((global::System.Data.SqlClient.SqlTransaction)(workTransaction));
                    if (this._tempCusDTLTableAdapter.Adapter.AcceptChangesDuringUpdate) {
                        this._tempCusDTLTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._tempCusDTLTableAdapter.Adapter);
                    }
                }
                if ((this._transportUnitTableAdapter != null)) {
                    revertConnections.Add(this._transportUnitTableAdapter, this._transportUnitTableAdapter.Connection);
                    this._transportUnitTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(workConnection));
                    this._transportUnitTableAdapter.Transaction = ((global::System.Data.SqlClient.SqlTransaction)(workTransaction));
                    if (this._transportUnitTableAdapter.Adapter.AcceptChangesDuringUpdate) {
                        this._transportUnitTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(this._transportUnitTableAdapter.Adapter);
                    }
                }
                if ((this.UpdateOrder == UpdateOrderOption.UpdateInsertDelete)) {
                    result = (result + this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows));
                    result = (result + this.UpdateInsertedRows(dataSet, allAddedRows));
                }
                else {
                    result = (result + this.UpdateInsertedRows(dataSet, allAddedRows));
                    result = (result + this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows));
                }
                result = (result + this.UpdateDeletedRows(dataSet, allChangedRows));
                workTransaction.Commit();
                if ((0 < allAddedRows.Count)) {
                    global::System.Data.DataRow[] rows = new System.Data.DataRow[allAddedRows.Count];
                    allAddedRows.CopyTo(rows);
                    for (int i = 0; (i < rows.Length); i = (i + 1)) {
                        global::System.Data.DataRow row = rows[i];
                        row.AcceptChanges();
                    }
                }
                if ((0 < allChangedRows.Count)) {
                    global::System.Data.DataRow[] rows = new System.Data.DataRow[allChangedRows.Count];
                    allChangedRows.CopyTo(rows);
                    for (int i = 0; (i < rows.Length); i = (i + 1)) {
                        global::System.Data.DataRow row = rows[i];
                        row.AcceptChanges();
                    }
                }
            }
            catch (global::System.Exception ex) {
                workTransaction.Rollback();
                if (this.BackupDataSetBeforeUpdate) {
                    global::System.Diagnostics.Debug.Assert((backupDataSet != null));
                    dataSet.Clear();
                    dataSet.Merge(backupDataSet);
                }
                else {
                    if ((0 < allAddedRows.Count)) {
                        global::System.Data.DataRow[] rows = new System.Data.DataRow[allAddedRows.Count];
                        allAddedRows.CopyTo(rows);
                        for (int i = 0; (i < rows.Length); i = (i + 1)) {
                            global::System.Data.DataRow row = rows[i];
                            row.AcceptChanges();
                            row.SetAdded();
                        }
                    }
                }
                throw ex;
            }
            finally {
                if (workConnOpened) {
                    workConnection.Close();
                }
                if ((this._customerTableAdapter != null)) {
                    this._customerTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(revertConnections[this._customerTableAdapter]));
                    this._customerTableAdapter.Transaction = null;
                }
                if ((this._jobTableAdapter != null)) {
                    this._jobTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(revertConnections[this._jobTableAdapter]));
                    this._jobTableAdapter.Transaction = null;
                }
                if ((this._loadTableAdapter != null)) {
                    this._loadTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(revertConnections[this._loadTableAdapter]));
                    this._loadTableAdapter.Transaction = null;
                }
                if ((this._loginTableAdapter != null)) {
                    this._loginTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(revertConnections[this._loginTableAdapter]));
                    this._loginTableAdapter.Transaction = null;
                }
                if ((this._tempCusDTLTableAdapter != null)) {
                    this._tempCusDTLTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(revertConnections[this._tempCusDTLTableAdapter]));
                    this._tempCusDTLTableAdapter.Transaction = null;
                }
                if ((this._transportUnitTableAdapter != null)) {
                    this._transportUnitTableAdapter.Connection = ((global::System.Data.SqlClient.SqlConnection)(revertConnections[this._transportUnitTableAdapter]));
                    this._transportUnitTableAdapter.Transaction = null;
                }
                if ((0 < adaptersWithAcceptChangesDuringUpdate.Count)) {
                    global::System.Data.Common.DataAdapter[] adapters = new System.Data.Common.DataAdapter[adaptersWithAcceptChangesDuringUpdate.Count];
                    adaptersWithAcceptChangesDuringUpdate.CopyTo(adapters);
                    for (int i = 0; (i < adapters.Length); i = (i + 1)) {
                        global::System.Data.Common.DataAdapter adapter = adapters[i];
                        adapter.AcceptChangesDuringUpdate = true;
                    }
                }
            }
            return result;
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected virtual void SortSelfReferenceRows(global::System.Data.DataRow[] rows, global::System.Data.DataRelation relation, bool childFirst) {
            global::System.Array.Sort<global::System.Data.DataRow>(rows, new SelfReferenceComparer(relation, childFirst));
        }
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        protected virtual bool MatchTableAdapterConnection(global::System.Data.IDbConnection inputConnection) {
            if ((this._connection != null)) {
                return true;
            }
            if (((this.Connection == null) 
                        || (inputConnection == null))) {
                return true;
            }
            if (string.Equals(this.Connection.ConnectionString, inputConnection.ConnectionString, global::System.StringComparison.Ordinal)) {
                return true;
            }
            return false;
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        public enum UpdateOrderOption {
            InsertUpdateDelete = 0,
            UpdateInsertDelete = 1,
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
        private class SelfReferenceComparer : object, global::System.Collections.Generic.IComparer<global::System.Data.DataRow> {
            private global::System.Data.DataRelation _relation;
            private int _childFirst;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            internal SelfReferenceComparer(global::System.Data.DataRelation relation, bool childFirst) {
                this._relation = relation;
                if (childFirst) {
                    this._childFirst = -1;
                }
                else {
                    this._childFirst = 1;
                }
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            private global::System.Data.DataRow GetRoot(global::System.Data.DataRow row, out int distance) {
                global::System.Diagnostics.Debug.Assert((row != null));
                global::System.Data.DataRow root = row;
                distance = 0;
                global::System.Collections.Generic.IDictionary<global::System.Data.DataRow, global::System.Data.DataRow> traversedRows = new global::System.Collections.Generic.Dictionary<global::System.Data.DataRow, global::System.Data.DataRow>();
                traversedRows[row] = row;
                global::System.Data.DataRow parent = row.GetParentRow(this._relation, global::System.Data.DataRowVersion.Default);
                for (
                ; ((parent != null) 
                            && (traversedRows.ContainsKey(parent) == false)); 
                ) {
                    distance = (distance + 1);
                    root = parent;
                    traversedRows[parent] = parent;
                    parent = parent.GetParentRow(this._relation, global::System.Data.DataRowVersion.Default);
                }
                if ((distance == 0)) {
                    traversedRows.Clear();
                    traversedRows[row] = row;
                    parent = row.GetParentRow(this._relation, global::System.Data.DataRowVersion.Original);
                    for (
                    ; ((parent != null) 
                                && (traversedRows.ContainsKey(parent) == false)); 
                    ) {
                        distance = (distance + 1);
                        root = parent;
                        traversedRows[parent] = parent;
                        parent = parent.GetParentRow(this._relation, global::System.Data.DataRowVersion.Original);
                    }
                }
                return root;
            }
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
            public int Compare(global::System.Data.DataRow row1, global::System.Data.DataRow row2) {
                if (object.ReferenceEquals(row1, row2)) {
                    return 0;
                }
                if ((row1 == null)) {
                    return -1;
                }
                if ((row2 == null)) {
                    return 1;
                }
                int distance1 = 0;
                global::System.Data.DataRow root1 = this.GetRoot(row1, out distance1);
                int distance2 = 0;
                global::System.Data.DataRow root2 = this.GetRoot(row2, out distance2);
                if (object.ReferenceEquals(root1, root2)) {
                    return (this._childFirst * distance1.CompareTo(distance2));
                }
                else {
                    global::System.Diagnostics.Debug.Assert(((root1.Table != null) 
                                    && (root2.Table != null)));
                    if ((root1.Table.Rows.IndexOf(root1) < root2.Table.Rows.IndexOf(root2))) {
                        return -1;
                    }
                    else {
                        return 1;
                    }
                }
            }
        }
    }
}
#pragma warning restore 1591
