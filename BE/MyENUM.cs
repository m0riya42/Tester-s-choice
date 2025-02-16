﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BE
{
    public enum Gender { male, female };
    public enum CarType { privateCar, TwoWheel, MedTruck, HeavyTruck };
    public enum Gearbox { Auto, Manual };
    public enum TestDetailChoice { KeptDistance,reverseParking,mirrors ,signal, speed, TesterInvolved,  EnterToJuction, PrepareToDrive}
    public enum FiveDays { sunday, monday, tuesday, wednesday, thursday};
    public enum PasswordScore
    {
        //Blank = 0,
        //VeryWeak = 1,
        //Weak = 2,
        //Medium = 3,
        //Strong = 4,
        //VeryStrong = 5

        /// <summary>
        /// Blank Password (empty and/or space chars only)
        /// </summary>
        Blank = 0,
        /// <summary>
        /// Either too short (less than 5 chars), one-case letters only or digits only
        /// </summary>
        VeryWeak = 1,
        /// <summary>
        /// At least 5 characters, one strong condition met (>= 8 chars with 1 or more UC letters, LC letters, digits & special chars)
        /// </summary>
        Weak = 2,
        /// <summary>
        /// At least 5 characters, two strong conditions met (>= 8 chars with 1 or more UC letters, LC letters, digits & special chars)
        /// </summary>
        Medium = 3,
        /// <summary>
        /// At least 8 characters, three strong conditions met (>= 8 chars with 1 or more UC letters, LC letters, digits & special chars)
        /// </summary>
        Strong = 4,
        /// <summary>
        /// At least 8 characters, all strong conditions met (>= 8 chars with 1 or more UC letters, LC letters, digits & special chars)
        /// </summary>
        VeryStrong = 5
    }


}
