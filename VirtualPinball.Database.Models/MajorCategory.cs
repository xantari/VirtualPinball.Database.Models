using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace VirtualPinball.Database.Models
{
    public enum MajorCategory
    {
        [Description("Unknown")]
        Unknown,
        [Description("Wheel")]
        Wheel,
        [Description("Flyer")]
        Flyer,
        [Description("Instruction Card")]
        InstructionCard,
        [Description("Backglass")]
        Backglass,
        [Description("Media Pack")]
        MediaPack,
        [Description("Other Front End Media")]
        OtherFrontEndMedia,
        [Description("Table")]
        Table,
        [Description("Topper")]
        Topper,
        [Description("ROM")]
        ROM,
        [Description("Pinsound / Alt Sound")]
        Pinsound,
        [Description("POV File")]
        POV,
        [Description("Pup Pack")]
        PupPack,
        [Description("Other")]
        Other
    }
}
