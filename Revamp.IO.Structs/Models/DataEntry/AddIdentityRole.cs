﻿using System;

namespace Revamp.IO.Structs.Models.DataEntry
{
    public partial class Values
    {
        [Serializable]
        public class AddIdentityRole
        {
            public string V_ATTEMPTED_SQL { get; set; }
            public string V_PROCEDURE_NAME { get; set; } = "SP_I_IDENTITIES_ROLES";


            public long? I_BASE_IDENTITIES_ROLES_ID { get; set; } = 0;
            public long? I_PREV_IDENTITIES_ROLES_ID { get; set; } = 0;
            public Guid? I_BASE_IDENTITIES_ROLES_UUID { get; set; }
            public Guid? I_PREV_IDENTITIES_ROLES_UUID { get; set; }
            public long? I_IDENTITIES_ID { get; set; } = 1000;
            public char? I_ENABLED { get; set; } = 'Y';
            public DateTime? I_DT_AVAILABLE { get; set; }
            public DateTime? I_DT_END { get; set; }
            public string I_OBJECT_TYPE { get; set; } = "Grant";
            public Guid? I_ROLES_UUID { get; set; }
            public string I_THIS_CALLER { get; set; }
            public long? O_ERR_NUMB { get; set; }
            public string O_ERR_MESS { get; set; }
            public long? O_IDENTITIES_ROLES_ID { get; set; }
            public Guid? O_IDENTITIES_ROLES_UUID { get; set; }
        }
    }
}

namespace Revamp.IO.Structs.Models
{
    public partial class CASTGOOP
    {
        [Serializable]
        public class AddIdentityRole
        {
            public string V_ATTEMPTED_SQL { get; set; }
            public string V_PROCEDURE_NAME { get; set; } = "SP_I_IDENTITIES_ROLES";
            public object I_BASE_IDENTITIES_ROLES_ID { get; set; } = 0;
            public object I_PREV_IDENTITIES_ROLES_ID { get; set; } = 0;
            public object I_BASE_IDENTITIES_ROLES_UUID { get; set; }
            public object I_PREV_IDENTITIES_ROLES_UUID { get; set; }
            public object I_IDENTITIES_ID { get; set; } = 1000;
            public object I_ENABLED { get; set; } = 'Y';
            public object I_DT_AVAILABLE { get; set; }
            public object I_DT_END { get; set; }
            public object I_OBJECT_TYPE { get; set; } = "Grant";
            public object I_ROLES_UUID { get; set; }
            public object I_THIS_CALLER { get; set; }
            public object O_ERR_NUMB { get; set; }
            public object O_ERR_MESS { get; set; }
            public object O_IDENTITIES_ROLES_ID { get; set; }
            public object O_IDENTITIES_ROLES_UUID { get; set; }
        }
    }
}