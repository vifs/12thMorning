﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using _12thMorning.Models.Queslar;

namespace _12thMorning.Libraries.Queslar.Partners {
    public class PartnerTotalInfo {
        public ResTypes ResType;
        public double Res { get { return PartnersIncome.Where(x => x.ResType == ResType).Sum(x => x.ResPerHour); } }
        public long Taxed { get { return PartnersIncome.Where(x => x.ResType == ResType).Sum(x => x.TaxedPerHour); } }
        public long Pets { get { return PetsInfo.Where(x => x.ResType == ResType).Sum(x => x.PetFoodPerHour); } }
        public double Outcome { get { return Res - Taxed - Pets; } }


        private List<PartnerIncomeInfo> PartnersIncome;
        private List<PetInfo> PetsInfo;


        public PartnerTotalInfo(ResTypes res, List<PartnerIncomeInfo> partners, List<PetInfo> pets) {
            PartnersIncome = partners;
            PetsInfo = pets;
            ResType = res;
        }


    }
}
