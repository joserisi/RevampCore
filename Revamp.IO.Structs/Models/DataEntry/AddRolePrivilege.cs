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
        public class AddRolePrivilege
        {
            public string V_PROCEDURE_NAME { get; set; } = "SP_I_" + "ROLES_PRIVILEGES";
            public string V_ATTEMPTED_SQL { get; set; }
            public string I_THIS_CALLER { get; set; } = "";



            public long? I_BASE_ROLES_PRIVILEGES_ID { get; set; } = 0;
            public long? I_PREV_ROLES_PRIVILEGES_ID { get; set; } = 0;
            public Guid? I_BASE_ROLES_PRIVILEGES_UUID { get; set; }
            public Guid? I_PREV_ROLES_PRIVILEGES_UUID { get; set; }
            public long? I_IDENTITIES_ID { get; set; } = 1000;
            public char? I_ENABLED { get; set; } = 'Y';
            public DateTime? I_DT_AVAILABLE { get; set; }
            public DateTime? I_DT_END { get; set; }
            public string I_ROLE_NAME { get; set; }
            public string I_PRIVILEGE_NAME { get; set; }
            public Guid? I_CORES_UUID { get; set; }
            public long? I_CORES_ID { get; set; } = 1000;
            public long? O_ERR_NUMB { get; set; }
            public string O_ERR_MESS { get; set; }
            public long? O_ROLES_PRIVILEGES_ID { get; set; }
            public Guid? O_ROLES_PRIVILEGES_UUID { get; set; }
        }      
    }
}

namespace Revamp.IO.Structs.Models
{
    public partial class CASTGOOP
    {

    }
}