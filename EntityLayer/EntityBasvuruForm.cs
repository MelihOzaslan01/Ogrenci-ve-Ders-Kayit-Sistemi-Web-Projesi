﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBasvuruForm
    {
        private int basvuruId;
        private int basOgrId;
        private int basDersId;

        public int BasvuruId { get => basvuruId; set => basvuruId = value; }
        public int BasOgrId { get => basOgrId; set => basOgrId = value; }
        public int BasDersId { get => basDersId; set => basDersId = value; }
    }
}
