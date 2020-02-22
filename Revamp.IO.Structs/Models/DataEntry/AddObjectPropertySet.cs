﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revamp.IO.Structs.Models.DataEntry
{
    public partial class Values
    {
        [Serializable]
        public class AddObjectPropertySet
        {
            public string V_PROCEDURE_NAME { get; set; } = "SP_I_" + "OBJ_PROP_SETS";
            public string V_ATTEMPTED_SQL { get; set; }
            public string I_THIS_CALLER { get; set; } = "";

            public long? I_BASE_OBJ_PROP_SETS_ID { get; set; } = 0;
            public long? I_PREV_OBJ_PROP_SETS_ID { get; set; } = 0;
            public Guid? I_BASE_OBJ_PROP_SETS_UUID { get; set; }
            public Guid? I_PREV_OBJ_PROP_SETS_UUID { get; set; }
            public long? I_IDENTITIES_ID { get; set; } = 1000;
            public char? I_ENABLED { get; set; } = 'Y';
            public DateTime? I_DT_AVAILABLE { get; set; }
            public DateTime? I_DT_END { get; set; }
            public Guid? I_OBJECT_SETS_UUID { get; set; }
            public long? I_OBJECT_SETS_ID { get; set; }
            public string I_OBJECT_PROP_TYPE { get; set; }
            public string I_VALUE_DATATYPE { get; set; }
            public string I_PROPERTY_NAME { get; set; }
            public string I_HAS_PARENT { get; set; }
            public string I_HAS_CHILD { get; set; }
            public long? I_PARENT_OBJ_PROP_SETS_ID { get; set; } = 0;
            public string I_PROPERTY_VALUE { get; set; } = " ";
            public long? O_ERR_NUMB { get; set; }
            public string O_ERR_MESS { get; set; }
            public long? O_OBJ_PROP_SETS_ID { get; set; }
            public Guid? O_OBJ_PROP_SETS_UUID { get; set; }

        }
    }
}

namespace Revamp.IO.Structs.Models
{
    public partial class CASTGOOP
    {
        [Serializable]
        public class ObjectPropSets
        {
            public string V_ATTEMPTED_SQL { get; set; }
            public string I_THIS_CALLER { get; set; } = "";
            public bool V_AVOID_ANTIXSS { get; set; } = false;
            public string V_PROCEDURE_NAME { get; set; } = "SP_I_OBJ_PROP_SETS";
            public object I_BASE_OBJ_PROP_SETS_ID { get; set; } = 0;
            public object I_PREV_OBJ_PROP_SETS_ID { get; set; } = 0;
            public object I_BASE_OBJ_PROP_SETS_UUID { get; set; }
            public object I_PREV_OBJ_PROP_SETS_UUID { get; set; }
            public object I_IDENTITIES_ID { get; set; } = 1000;
            public object I_ENABLED { get; set; } = 'Y';
            public object I_DT_AVAILABLE { get; set; }
            public object I_DT_END { get; set; }
            public object I_OBJECT_SETS_UUID { get; set; }
            public object I_OBJECT_SETS_ID { get; set; }
            public object I_OBJECT_PROP_TYPE { get; set; }
            public object I_VALUE_DATATYPE { get; set; }
            public object I_PROPERTY_NAME { get; set; }
            public object I_HAS_PARENT { get; set; }
            public object I_HAS_CHILD { get; set; }
            public object I_PARENT_OBJ_PROP_SETS_ID { get; set; }
            public object I_PROPERTY_VALUE { get; set; }
            public object O_ERR_NUMB { get; set; }
            public object O_ERR_MESS { get; set; }
            public object O_OBJ_PROP_SETS_ID { get; set; }
            public object O_OBJ_PROP_SETS_UUID { get; set; }

            public virtual List<ViewObjectPropOptSetsModel> ObjectPropOptSets { get; set; }
            public virtual List<ViewObjectPropSetFile> PropFiles { get; set; }
            public virtual List<ViewObjectPropSetString> PropStrings { get; set; }
            public virtual List<ViewObjectPropSetNumb> PropNumb { get; set; }
            public virtual List<ViewObjectPropSetDate> PropDate { get; set; }
            public virtual List<ViewObjectPropFile> Files { get; set; }

        }
    }
}