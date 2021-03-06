﻿using System;

namespace Revamp.IO.Structs.Models.DataEntry
{
    public partial class Values
    {
        [Serializable]
        public class AddObjectPropSetDataFile
        {
            public string V_ATTEMPTED_SQL { get; set; }
            public string V_PROCEDURE_NAME { get; set; } = "SP_I_OBJ_PROP_SETS_DAT_FILE";
            public long? I_BASE_OBJ_PROP_SETS_DAT_FILE_ID { get; set; } = 0;
            public long? I_PREV_OBJ_PROP_SETS_DAT_FILE_ID { get; set; } = 0;
            public Guid? I_BASE_OBJ_PROP_SETS_DAT_FILE_UUID { get; set; }
            public Guid? I_PREV_OBJ_PROP_SETS_DAT_FILE_UUID { get; set; }
            public long? I_IDENTITIES_ID { get; set; } = 1000;
            public char? I_ENABLED { get; set; } = 'Y';
            public DateTime? I_DT_AVAILABLE { get; set; }
            public DateTime? I_DT_END { get; set; }
            public Guid? I_OBJ_PROP_SETS_UUID { get; set; }
            public string I_FILE_NAME { get; set; }
            public long? I_FILE_SIZE { get; set; }
            public string I_CONTENT_TYPE { get; set; }
            public byte[] I_VALUE { get; set; }
            public string I_THIS_CALLER { get; set; }
            public long? O_ERR_NUMB { get; set; }
            public string O_ERR_MESS { get; set; }
            public long? O_OBJ_PROP_SETS_DAT_FILE_ID { get; set; }
            public Guid? O_OBJ_PROP_SETS_DAT_FILE_UUID { get; set; }
        }
    }
}

namespace Revamp.IO.Structs.Models
{
    public partial class CASTGOOP
    {
        [Serializable]
        public class AddObjectPropSetDataFile
        {
            public bool V_AVOID_ANTIXSS { get; set; } = false;
            public string V_ATTEMPTED_SQL { get; set; }
            public string V_PROCEDURE_NAME { get; set; } = "SP_I_OBJ_PROP_SETS_DAT_FILE";
            public object I_BASE_OBJ_PROP_SETS_DAT_FILE_ID { get; set; } = 0;
            public object I_PREV_OBJ_PROP_SETS_DAT_FILE_ID { get; set; } = 0;
            public object I_BASE_OBJ_PROP_SETS_DAT_FILE_UUID { get; set; }
            public object I_PREV_OBJ_PROP_SETS_DAT_FILE_UUID { get; set; }
            public object I_IDENTITIES_ID { get; set; } = 1000;
            public object I_ENABLED { get; set; } = 'Y';
            public object I_DT_AVAILABLE { get; set; }
            public object I_DT_END { get; set; }
            public object I_OBJ_PROP_SETS_UUID { get; set; }
            public object I_FILE_NAME { get; set; }
            public object I_FILE_SIZE { get; set; }
            public object I_CONTENT_TYPE { get; set; }
            public object I_VALUE { get; set; }
            public string I_THIS_CALLER { get; set; }
            public object O_ERR_NUMB { get; set; }
            public object O_ERR_MESS { get; set; }
            public object O_OBJ_PROP_SETS_DAT_FILE_ID { get; set; }
            public object O_OBJ_PROP_SETS_DAT_FILE_UUID { get; set; }
            
        }
    }
}