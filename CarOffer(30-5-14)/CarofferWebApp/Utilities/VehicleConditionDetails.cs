using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarofferWebApp.Utilities
{
    public class VehicleConditionDetails
    {
        // 1.Left Mirror
        public Boolean Inoperable_LM { get; set; }
        public Boolean Damaged_LM { get; set; }
        public Boolean Replacement_Required_LM { get; set; }

        // 2.Front Left Window
        public Boolean Has_Small_Chip_FLW { get; set; }
        public Boolean Multiple_Chips_FLW { get; set; }
        public Boolean Scratched_FLW { get; set; }
        public Boolean Cracked_FLW { get; set; }

        //3. Rear Left window
        public Boolean Has_Small_Chip_RLW { get; set; }
        public Boolean Multiple_Chips_RLW { get; set; }
        public Boolean Scratched_RLW { get; set; }
        public Boolean Cracked_RLW { get; set; }

        //4. Front Left Door
        public Boolean Paint_Chip_FLD { get; set; }
        public Boolean Small_Scratch_FLD { get; set; }
        public Boolean Deep_Scratch_FLD { get; set; }
        public Boolean Small_Dent_FLD { get; set; }
        public Boolean Large_Dent_FLD { get; set; }
        public Boolean Previous_Repaint_FLD { get; set; }
        public Boolean Requires_Repaint_FLD { get; set; }

        //5. Rear Left Door

        public Boolean Paint_Chip_RLD { get; set; }
        public Boolean Small_Scratch_RLD { get; set; }
        public Boolean Deep_Scratch_RLD { get; set; }
        public Boolean Small_Dent_RLD { get; set; }
        public Boolean Large_Dent_RLD { get; set; }
        public Boolean Previous_Repaint_RLD { get; set; }
        public Boolean Requires_Repaint_RLD { get; set; }


        // 6.Rear Left Quarter Panel

        public Boolean Paint_Chip_RLQP { get; set; }
        public Boolean Small_Scratch_RLQP { get; set; }
        public Boolean Deep_Scratch_RLQP { get; set; }
        public Boolean Small_Dent_RLQP { get; set; }
        public Boolean Large_Dent_RLQP { get; set; }
        public Boolean Previous_Repaint_RLQP { get; set; }
        public Boolean Requires_Repaint_RLQP { get; set; }

        //7. Rear Left Wheel & Tire

        public Boolean New_Tire_RLWT { get; set; }
        public Boolean Tire_Less_than_50_RLWT { get; set; }
        public Boolean Mismatched_RLWT { get; set; }
        public Boolean Tire_Needs_Replacement_RLWT { get; set; }
        public Boolean Curbed_Wheel_RLWT { get; set; }
        public Boolean Wheel_Needs_Replacement_RLWT { get; set; }

        //8. Front Left Wheel & Tire
        public Boolean New_Tire_FLWT { get; set; }
        public Boolean Tire_Less_than_50_FLWT { get; set; }
        public Boolean Mismatched_FLWT { get; set; }
        public Boolean Tire_Needs_Replacement_FLWT { get; set; }
        public Boolean Curbed_Wheel_FLWT { get; set; }
        public Boolean Wheel_Needs_Replacement_FLWT { get; set; }

        //9. Roof
        public Boolean Paint_Chip_Roof { get; set; }
        public Boolean Small_Scratch_Roof { get; set; }
        public Boolean Deep_Scratch_Roof { get; set; }
        public Boolean Small_Dent_Roof { get; set; }
        public Boolean Large_Dent_Roof { get; set; }
        public Boolean Previous_Repaint_Roof { get; set; }
        public Boolean Requires_Repaint_Roof { get; set; }

        //10. Front Windshield
        public Boolean Has_Small_Chip_FWindShield { get; set; }
        public Boolean Multiple_Chips_FWindShield { get; set; }
        public Boolean Scratched_FWindShield { get; set; }
        public Boolean Cracked_FWindShield { get; set; }

        //11. Hood

        public Boolean Paint_Chip_Hood { get; set; }
        public Boolean Small_Scratch_Hood { get; set; }
        public Boolean Deep_Scratch_Hood { get; set; }
        public Boolean Small_Dent_Hood { get; set; }
        public Boolean Large_Dent_Hood { get; set; }
        public Boolean Previous_Repaint_Hood { get; set; }
        public Boolean Requires_Repaint_Hood { get; set; }

        // 12.Front Left Headlight
        public Boolean Inoperable_FLH { get; set; }
        public Boolean Damaged_FLH { get; set; }
        public Boolean Replacement_Required_FLH { get; set; }

        // 13.Front Bumper

        public Boolean Paint_Chip_FBumper { get; set; }
        public Boolean Small_Scratch_FBumper { get; set; }
        public Boolean Deep_Scratch_FBumper { get; set; }
        public Boolean Small_Dent_FBumper { get; set; }
        public Boolean Large_Dent_FBumper { get; set; }
        public Boolean Previous_Repaint_FBumper { get; set; }
        public Boolean Requires_Repaint_FBumper { get; set; }

        // 14.Front Left Fender

        public Boolean Paint_Chip_FLFender { get; set; }
        public Boolean Small_Scratch_FLFender { get; set; }
        public Boolean Deep_Scratch_FLFender { get; set; }
        public Boolean Small_Dent_FLFender { get; set; }
        public Boolean Large_Dent_FLFender { get; set; }
        public Boolean Previous_Repaint_FLFender { get; set; }
        public Boolean Requires_Repaint_FLFender { get; set; }

        // 15.Right Mirror
        public Boolean Inoperable_RM { get; set; }
        public Boolean Damaged_RM { get; set; }
        public Boolean Replacement_Required_RM { get; set; }

        //16. Front Right Fender
        public Boolean Paint_Chip_FRFender { get; set; }
        public Boolean Small_Scratch_FRFender { get; set; }
        public Boolean Deep_Scratch_FRFender { get; set; }
        public Boolean Small_Dent_FRFender { get; set; }
        public Boolean Large_Dent_FRFender { get; set; }
        public Boolean Previous_Repaint_FRFender { get; set; }
        public Boolean Requires_Repaint_FRFender { get; set; }

        //17. Front Right Window
        public Boolean Has_Small_Chip_FRW { get; set; }
        public Boolean Multiple_Chips_FRW { get; set; }
        public Boolean Scratched_FRW { get; set; }
        public Boolean Cracked_FRW { get; set; }

        //18. Rear Right Window
        public Boolean Has_Small_Chip_RRW { get; set; }
        public Boolean Multiple_Chips_RRW { get; set; }
        public Boolean Scratched_RRW { get; set; }
        public Boolean Cracked_RRW { get; set; }

        //19. Rear Windshield
        public Boolean Has_Small_Chip_RWindShield { get; set; }
        public Boolean Multiple_Chips_RWindShield { get; set; }
        public Boolean Scratched_RWindShield { get; set; }
        public Boolean Cracked_RWindShield { get; set; }

        // 20.Front Right Wheel & Tire

        public Boolean New_Tire_FRWT { get; set; }
        public Boolean Tire_Less_than_50_FRWT { get; set; }
        public Boolean Mismatched_FRWT { get; set; }
        public Boolean Tire_Needs_Replacement_FRWT { get; set; }
        public Boolean Curbed_Wheel_FRWT { get; set; }
        public Boolean Wheel_Needs_Replacement_FRWT { get; set; }

        //21. Rear Right Wheel & Tire

        public Boolean New_Tire_RRightWheel { get; set; }
        public Boolean Tire_Less_than_50_RRightWheel { get; set; }
        public Boolean Mismatched_RRightWheel { get; set; }
        public Boolean Tire_Needs_Replacement_RRightWheel { get; set; }
        public Boolean Curbed_Wheel_RRightWheel { get; set; }
        public Boolean Wheel_Needs_Replacement_RRightWheel { get; set; }



        //   22.Rear Right Quarter Panel 	

        public Boolean Paint_Chip_RearRQP { get; set; }
        public Boolean Small_Scratch_RearRQP { get; set; }
        public Boolean Deep_Scratch_RearRQP { get; set; }
        public Boolean Small_Dent_RearRQP { get; set; }
        public Boolean Large_Dent_RearRQP { get; set; }
        public Boolean Previous_Repaint_RearRQP { get; set; }
        public Boolean Requires_Repaint_RearRQP { get; set; }


        //23. Right Tail Light

        public Boolean Inoperable_RearTailLight { get; set; }
        public Boolean Damaged_RearTailLight { get; set; }
        public Boolean Replacement_Required_RearTailLight { get; set; }

        // 24.Trunk
        public Boolean Paint_Chip_Trunk { get; set; }
        public Boolean Small_Scratch_Trunk { get; set; }
        public Boolean Deep_Scratch_Trunk { get; set; }
        public Boolean Small_Dent_Trunk { get; set; }
        public Boolean Large_Dent_Trunk { get; set; }
        public Boolean Previous_Repaint_Trunk { get; set; }
        public Boolean Requires_Repaint_Trunk { get; set; }

        //25. Rear Bumper
        public Boolean Paint_Chip_RearBumper { get; set; }
        public Boolean Small_Scratch_RearBumper { get; set; }
        public Boolean Deep_Scratch_RearBumper { get; set; }
        public Boolean Small_Dent_RearBumper { get; set; }
        public Boolean Large_Dent_RearBumper { get; set; }
        public Boolean Previous_Repaint_RearBumper { get; set; }
        public Boolean Requires_Repaint_RearBumper { get; set; }

        //26. Left Tail Light(driver side)

        public Boolean Inoperable_LeftTailLight { get; set; }
        public Boolean Damaged_LeftTailLight { get; set; }
        public Boolean Replacement_Required_LeftTailLight { get; set; }

        //27. Front Right Door
        public Boolean Paint_Chip_FRDoor { get; set; }
        public Boolean Small_Scratch_FRDoor { get; set; }
        public Boolean Deep_Scratch_FRDoor { get; set; }
        public Boolean Small_Dent_FRDoor { get; set; }
        public Boolean Large_Dent_FRDoor { get; set; }
        public Boolean Previous_Repaint_FRDoor { get; set; }
        public Boolean Requires_Repaint_FRDoor { get; set; }

        //28. Rear Right Door
        public Boolean Paint_Chip_RRDoor { get; set; }
        public Boolean Small_Scratch_RRDoor { get; set; }
        public Boolean Deep_Scratch_RRDoor { get; set; }
        public Boolean Small_Dent_RRDoor { get; set; }
        public Boolean Large_Dent_RRDoor { get; set; }
        public Boolean Previous_Repaint_RRDoor { get; set; }
        public Boolean Requires_Repaint_RRDoor { get; set; }

        // 29.Front Right Headlight
        public Boolean Inoperable_FrontRightHeadLight { get; set; }
        public Boolean Damaged_FrontRightHeadLight { get; set; }
        public Boolean Replacement_Required_FrontRightHeadLight { get; set; }

        // Interior condition 
        public Boolean Excelent_InteriorC { get; set; }
        public Boolean Good_InteriorC { get; set; }
        public Boolean Average_InteriorC { get; set; }
        public Boolean Poor_InteriorC { get; set; }
        public string InteriorConditionData { get; set; }
        // Mechanical condition.

        public Boolean Excelent_MechanicalC { get; set; }
        public Boolean Good_MechanicalC { get; set; }
        public Boolean Average_MechanicalC { get; set; }
        public Boolean Poor_MechanicalC { get; set; }
        public string MechanicalConditionData { get; set; }

    }
}