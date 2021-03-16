using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroCreator.Models
{
	public class Hero
	{
		[Key]
		public int Id { get; set; }
		public string superhero { get; set; }
		public string AlterEgo { get; set; }
		public string PrimarySuperheroAbility { get; set; }
		public string SecondarySuperheroAbility { get; set; }
		public string CatchPhrase { get; set; }
	}
}
