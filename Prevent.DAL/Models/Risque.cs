﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
	/// <summary>
	/// Risque : Danger éventuel plus ou moins prévisible.
	/// </summary>
	public class Risque : Entity
    {
        public int Type { get; set; }
        public string? Nature { get; set; }
        public string? Vecteur { get; set; }
        public string? Description { get; set; }

        /// <summary>
        /// ActiviteRisques : Activités exposant à ce Risque (many-to-many)
        /// Un même risque peut être induit par plusieurs activités
        /// </summary>
        public virtual ICollection<ActiviteRisque> ActivitesRisques { get; set; } = [];

        /// <summary>
        /// Les mesures de prévention enregistrées pour un Risque donné.
        /// </summary>
        public virtual ICollection<PreventionRisque> PreventionsRisques { get; set; } = [];

        /// <summary>
        /// Les Espaces exposés à ce Risque.
        /// </summary>
        public virtual ICollection<RisqueReference> RisquesReferences { get; set; } = [];
    }
}
