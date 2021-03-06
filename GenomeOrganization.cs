﻿using System;
using System.Collections.Generic;
using System.Text;
using static QTLProject.Types;

namespace QTLProject
{
    public class GenomeOrganization
    {
      
        public MappingIndex MappingFunctionIndex { get; set; }//0=Haldane (independent recombinations), 1=Kossambi, ...(no need more for this project)
        public IList<Chromosome> Chromosome { get; set; }//list of all chromosomes in the genome (Human: includes also X and Y even for Women having no Y chromosome)
    }
}
