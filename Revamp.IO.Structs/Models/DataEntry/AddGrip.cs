﻿using System;
using System.Collections.Generic;

namespace Revamp.IO.Structs.Models.DataEntry
{
    public partial class Values
    {
        [Serializable]
        public class AddGrip
        {
            public string V_ATTEMPTED_SQL { get; set; }
            public string I_THIS_CALLER { get; set; } = "";

            public string V_PROCEDURE_NAME { get; set; } = "SP_I_" + "GRIPS";
            public long? I_BASE_GRIPS_ID { get; set; } = 0;
            public long? I_PREV_GRIPS_ID { get; set; } = 0;
            public Guid? I_BASE_GRIPS_UUID { get; set; }
            public Guid? I_PREV_GRIPS_UUID { get; set; }
            public long? I_IDENTITIES_ID { get; set; } = 1000;
            public char? I_ENABLED { get; set; } = 'Y';
            public DateTime? I_DT_AVAILABLE { get; set; }
            public DateTime? I_DT_END { get; set; }
            public Guid? I_STAGES_UUID { get; set; }
            public long? I_STAGES_ID { get; set; }
            public string I_STAGE_TYPE { get; set; }
            public string I_STAGE_NAME { get; set; }
            public string I_GRIP_TYPE { get; set; }
            public string I_GRIP_NAME { get; set; }
            public long? O_ERR_NUMB { get; set; }
            public string O_ERR_MESS { get; set; }
            public long? O_GRIPS_ID { get; set; }
            public Guid? O_GRIPS_UUID { get; set; }
        }
    }
}

namespace Revamp.IO.Structs.Models
{
    public partial class CASTGOOP
    {
        [Serializable]
        public class Grip
        {

            public long? applications_id { get; set; }
            public string V_ATTEMPTED_SQL { get; set; }
            public string I_THIS_CALLER { get; set; } = "";

            public string V_PROCEDURE_NAME { get; set; } = "SP_I_GRIPS";
            public object I_BASE_GRIPS_ID { get; set; } = 0;
            public object I_PREV_GRIPS_ID { get; set; } = 0;
            public object I_BASE_GRIPS_UUID { get; set; }
            public object I_PREV_GRIPS_UUID { get; set; }
            public object I_IDENTITIES_ID { get; set; } = 1000;
            public object I_ENABLED { get; set; } = 'Y';
            public object I_DT_AVAILABLE { get; set; }
            public object I_DT_END { get; set; }
            public object I_STAGES_UUID { get; set; }
            public object I_STAGES_ID { get; set; }
            public object I_STAGE_TYPE { get; set; }
            public object I_STAGE_NAME { get; set; }
            public object I_GRIP_TYPE { get; set; }
            public object I_GRIP_NAME { get; set; }
            public object O_ERR_NUMB { get; set; }
            public object O_ERR_MESS { get; set; }
            public object O_GRIPS_ID { get; set; }
            public object O_GRIPS_UUID { get; set; }

            public List<ObjectSet> ObjectSets { get; set; }
        }
    }
}