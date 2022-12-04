namespace VLC.Models.Nutrition
{
    public class NutritionFacts
    {

        public NutritionFacts()
        {
        }

        #region Methods
        /// <summary>
        ///  Get macronutrient dictionaries (carbs, proteins, fats)
        /// </summary>
        /// <returns>An array of carbohydrate, protein, and fats dictionaries</returns>
        public Dictionary<string, string>[] GetMacros() => new Dictionary<string, string>[] { Carbs, Proteins, Fats };


        /// <summary>
        /// Get micronutrient dictionaries based on https://mynutrition.wsu.edu/nutrition-basics
        /// </summary>
        /// <returns>An array of micronutrient dictionaries</returns>
        public Dictionary<string, string>[] GetMicros() => new Dictionary<string, string>[]
        {
            thiamine, riboflavin, vit_b6, vit_b12, vit_c, folate, // Water soluable 
            vit_a, vit_d, vit_e, vit_k, // Fat soluable
            calcium, potassium, sodium, iron, zinc, //minerals
            water // water
        };
        #endregion

        #region Serving Facts
        public double? ServingsPerContainer { get; set; } = default;
        public int? ServingSize { get; set; } = 100;
        public string? ServingSizeUnits { get; set; } = "g";
        public int CaloriesPerServing { get; set; } //new() { { "Id", $"" }, { "display_name", "Calories" }, { "daily_value", "" }, { "units", "kcal" } };
        public int CaloriesPerContainer { get; set; }
        public int CaloriesPer100g { get; set; }
        #endregion

        #region  Macronutrition
        public Dictionary<string, string> Carbs => new() { { "Id", $"{Nutrient.carbs}" }, { "display_name", "Carbs" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> Sugar => new() { { "Id", $"{Nutrient.sugar}" }, { "display_name", "Sugar" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> Fats => new() { { "Id", $"{Nutrient.fats}" }, { "display_name", "Fats" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> Saturated_fats => new() { { "Id", $"{Nutrient.saturated_fats}" }, { "display_name", "Saturated fats" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> Trans_fats => new() { { "Id", $"{Nutrient.trans_fats}" }, { "display_name", "Trans fats" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> Monounsaturated_fats => new() { { "Id", $"{Nutrient.monounsaturated_fats}" }, { "display_name", "Monounsaturated fats" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> Polyunsaturated_fats => new() { { "Id", $"{Nutrient.polyunsaturated_fats}" }, { "display_name", "Polyunsaturated fats" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> Cholesterol => new() { { "Id", $"{Nutrient.cholesterol}" }, { "display_name", "Cholesterol" }, { "daily_value", "" }, { "units", "mg" } };
        public Dictionary<string, string> Proteins => new() { { "Id", $"{Nutrient.proteins}" }, { "display_name", "Proteins" }, { "daily_value", "" }, { "units", "g" } };

        #endregion

        #region Vitamins
        public Dictionary<string, string> vit_a => new() { { "Id", $"{Nutrient.vit_a}" }, { "display_name", "Vit A" }, { "daily_value", "900" }, { "units", "μg" } };
        public Dictionary<string, string> riboflavin => new() { { "Id", $"{Nutrient.riboflavin}" }, { "display_name", "Riboflavin (B2)" }, { "daily_value", "1.7" }, { "units", "mg" } };
        public Dictionary<string, string> vit_a_iu => new() { { "Id", $"{Nutrient.vit_a_iu}" }, { "display_name", "Vit A IU" }, { "daily_value", "" }, { "units", "IU" } };
        public Dictionary<string, string> vit_b12 => new() { { "Id", $"{Nutrient.vit_b12}" }, { "display_name", "Vit B12" }, { "daily_value", "2.4" }, { "units", "μg" } };
        public Dictionary<string, string> vit_b6 => new() { { "Id", $"{Nutrient.vit_b6}" }, { "display_name", "Vit B6" }, { "daily_value", "1.3" }, { "units", "mg" } };
        public Dictionary<string, string> folate => new() { { "Id", $"{Nutrient.folate}" }, { "display_name", "Folate (B9)" }, { "daily_value", "400" }, { "units", "μg" } };
        public Dictionary<string, string> vit_c => new() { { "Id", $"{Nutrient.vit_c}" }, { "display_name", "Vit C" }, { "daily_value", "60" }, { "units", "mg" } };
        public Dictionary<string, string> vit_d => new() { { "Id", $"{Nutrient.vit_d}" }, { "display_name", "Vit D" }, { "daily_value", "15" }, { "units", "μg" } };
        public Dictionary<string, string> vit_d2 => new() { { "Id", $"{Nutrient.vit_d2}" }, { "display_name", "Vit D2" }, { "daily_value", "" }, { "units", "μg" } };
        public Dictionary<string, string> vit_d3 => new() { { "Id", $"{Nutrient.vit_d3}" }, { "display_name", "Vit D3" }, { "daily_value", "" }, { "units", "μg" } };
        public Dictionary<string, string> vit_d_iu => new() { { "Id", $"{Nutrient.vit_d_iu}" }, { "display_name", "Vit D IU" }, { "daily_value", "" }, { "units", "IU" } };
        public Dictionary<string, string> vit_e => new() { { "Id", $"{Nutrient.vit_e}" }, { "display_name", "Vit E" }, { "daily_value", "20" }, { "units", "mg" } };
        public Dictionary<string, string> vit_k => new() { { "Id", $"{Nutrient.vit_k}" }, { "display_name", "Vit K" }, { "daily_value", "120" }, { "units", "μg" } };
        #endregion

        #region Minerals
        public Dictionary<string, string> ala_fatty_acid => new() { { "Id", $"{Nutrient.ala_fatty_acid}" }, { "display_name", "ALA" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> alanine => new() { { "Id", $"{Nutrient.alanine}" }, { "display_name", "Alanine" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> alcohol => new() { { "Id", $"{Nutrient.alcohol}" }, { "display_name", "Alcohol" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> alpha_carotene => new() { { "Id", $"{Nutrient.alpha_carotene}" }, { "display_name", "Alpha carotene" }, { "daily_value", "" }, { "units", "μg" } };
        public Dictionary<string, string> arginine => new() { { "Id", $"{Nutrient.arginine}" }, { "display_name", "Arginine" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> aspartic_acid => new() { { "Id", $"{Nutrient.aspartic_acid}" }, { "display_name", "Aspartic acid" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> beta_carotene => new() { { "Id", $"{Nutrient.beta_carotene}" }, { "display_name", "Beta carotene" }, { "daily_value", "" }, { "units", "μg" } };
        public Dictionary<string, string> betaine => new() { { "Id", $"{Nutrient.betaine}" }, { "display_name", "Betaine" }, { "daily_value", "" }, { "units", "mg" } };
        public Dictionary<string, string> caffeine => new() { { "Id", $"{Nutrient.caffeine}" }, { "display_name", "Caffeine" }, { "daily_value", "" }, { "units", "mg" } };
        public Dictionary<string, string> calcium => new() { { "Id", $"{Nutrient.calcium}" }, { "display_name", "Calcium" }, { "daily_value", "1000" }, { "units", "mg" } };
        public Dictionary<string, string> choline => new() { { "Id", $"{Nutrient.choline}" }, { "display_name", "Choline" }, { "daily_value", "550" }, { "units", "mg" } };
        public Dictionary<string, string> copper => new() { { "Id", $"{Nutrient.copper}" }, { "display_name", "Copper" }, { "daily_value", "2" }, { "units", "mg" } };
        public Dictionary<string, string> cystine => new() { { "Id", $"{Nutrient.cystine}" }, { "display_name", "Cystine" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> dha_fatty_acid => new() { { "Id", $"{Nutrient.dha_fatty_acid}" }, { "display_name", "DHA" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> dpa_fatty_acid => new() { { "Id", $"{Nutrient.dpa_fatty_acid}" }, { "display_name", "DPA" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> epa_fatty_acid => new() { { "Id", $"{Nutrient.epa_fatty_acid}" }, { "display_name", "EPA" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> fiber => new() { { "Id", $"{Nutrient.fiber}" }, { "display_name", "Fiber" }, { "daily_value", "25" }, { "units", "g" } };
        public Dictionary<string, string> fluoride => new() { { "Id", $"{Nutrient.fluoride}" }, { "display_name", "Fluoride" }, { "daily_value", "" }, { "units", "μg" } };
        public Dictionary<string, string> fructose => new() { { "Id", $"{Nutrient.fructose}" }, { "display_name", "Fructose" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> galactose => new() { { "Id", $"{Nutrient.galactose}" }, { "display_name", "Galactose" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> glucose => new() { { "Id", $"{Nutrient.glucose}" }, { "display_name", "Glucose" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> glutamic_acid => new() { { "Id", $"{Nutrient.glutamic_acid}" }, { "display_name", "Glutamic acid" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> glycine => new() { { "Id", $"{Nutrient.glycine}" }, { "display_name", "Glycine" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> histidine => new() { { "Id", $"{Nutrient.histidine}" }, { "display_name", "Histidine" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> hydroxyproline => new() { { "Id", $"{Nutrient.hydroxyproline}" }, { "display_name", "Hydroxyproline" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> iron => new() { { "Id", $"{Nutrient.iron}" }, { "display_name", "Iron" }, { "daily_value", "8" }, { "units", "mg" } };
        public Dictionary<string, string> isoleucine => new() { { "Id", $"{Nutrient.isoleucine}" }, { "display_name", "Isoleucine" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> lactose => new() { { "Id", $"{Nutrient.lactose}" }, { "display_name", "Lactose" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> leucine => new() { { "Id", $"{Nutrient.leucine}" }, { "display_name", "Leucine" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> lycopene => new() { { "Id", $"{Nutrient.lycopene}" }, { "display_name", "Lycopene" }, { "daily_value", "" }, { "units", "μg" } };
        public Dictionary<string, string> lysine => new() { { "Id", $"{Nutrient.lysine}" }, { "display_name", "Lysine" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> magnesium => new() { { "Id", $"{Nutrient.magnesium}" }, { "display_name", "Magnesium" }, { "daily_value", "350" }, { "units", "mg" } };
        public Dictionary<string, string> maltose => new() { { "Id", $"{Nutrient.maltose}" }, { "display_name", "Maltose" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> manganese => new() { { "Id", $"{Nutrient.manganese}" }, { "display_name", "Manganese" }, { "daily_value", "2" }, { "units", "mg" } };
        public Dictionary<string, string> methionine => new() { { "Id", $"{Nutrient.methionine}" }, { "display_name", "Methionine" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> niacin => new() { { "Id", $"{Nutrient.niacin}" }, { "display_name", "Niacin" }, { "daily_value", "20" }, { "units", "mg" } };
        public Dictionary<string, string> pantothenic_acid => new() { { "Id", $"{Nutrient.pantothenic_acid}" }, { "display_name", "Pantothenic acid" }, { "daily_value", "" }, { "units", "mg" } };
        public Dictionary<string, string> phenylalanine => new() { { "Id", $"{Nutrient.phenylalanine}" }, { "display_name", "Phenylalanine" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> phosphorus => new() { { "Id", $"{Nutrient.phosphorus}" }, { "display_name", "Phosphorus" }, { "daily_value", "1000" }, { "units", "mg" } };
        public Dictionary<string, string> potassium => new() { { "Id", $"{Nutrient.potassium}" }, { "display_name", "Potassium" }, { "daily_value", "4700" }, { "units", "mg" } };
        public Dictionary<string, string> proline => new() { { "Id", $"{Nutrient.proline}" }, { "display_name", "Proline" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> retinol => new() { { "Id", $"{Nutrient.retinol}" }, { "display_name", "Retinol" }, { "daily_value", "" }, { "units", "μg" } };
        public Dictionary<string, string> selenium => new() { { "Id", $"{Nutrient.selenium}" }, { "display_name", "Selenium" }, { "daily_value", "70" }, { "units", "μg" } };
        public Dictionary<string, string> serine => new() { { "Id", $"{Nutrient.serine}" }, { "display_name", "Serine" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> sodium => new() { { "Id", $"{Nutrient.sodium}" }, { "display_name", "Sodium" }, { "daily_value", "2400" }, { "units", "mg" } };
        public Dictionary<string, string> starch => new() { { "Id", $"{Nutrient.starch}" }, { "display_name", "Starch" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> sucrose => new() { { "Id", $"{Nutrient.sucrose}" }, { "display_name", "Sucrose" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> theobromine => new() { { "Id", $"{Nutrient.theobromine}" }, { "display_name", "Theobromine" }, { "daily_value", "" }, { "units", "mg" } };
        public Dictionary<string, string> thiamine => new() { { "Id", $"{Nutrient.thiamine}" }, { "display_name", "Thiamine" }, { "daily_value", "1.5" }, { "units", "mg" } };
        public Dictionary<string, string> threonine => new() { { "Id", $"{Nutrient.threonine}" }, { "display_name", "Threonine" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> total_omega_3 => new() { { "Id", $"{Nutrient.total_omega_3}" }, { "display_name", "Total omega 3" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> total_omega_6 => new() { { "Id", $"{Nutrient.total_omega_6}" }, { "display_name", "Total omega 6" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> tryptophan => new() { { "Id", $"{Nutrient.tryptophan}" }, { "display_name", "Tryptophan" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> tyrosine => new() { { "Id", $"{Nutrient.tyrosine}" }, { "display_name", "Tyrosine" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> valine => new() { { "Id", $"{Nutrient.valine}" }, { "display_name", "Valine" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> water => new() { { "Id", $"{Nutrient.water}" }, { "display_name", "Water" }, { "daily_value", "" }, { "units", "g" } };
        public Dictionary<string, string> zinc => new() { { "Id", $"{Nutrient.zinc}" }, { "display_name", "Zinc" }, { "daily_value", "15" }, { "units", "mg" } };
        #endregion

        #region Enums
        public enum Nutrient
        {
            alanine,
            alcohol,
            arginine,
            aspartic_acid,
            betaine,
            caffeine,
            calcium,
            carbs,
            cholesterol,
            choline,
            copper,
            cystine,
            fats,
            fiber,
            fluoride,
            folate,
            fructose,
            galactose,
            glucose,
            glutamic_acid,
            glycine,
            histidine,
            hydroxyproline,
            iron,
            isoleucine,
            lactose,
            leucine,
            lycopene,
            lysine,
            magnesium,
            maltose,
            manganese,
            methionine,
            monounsaturated_fats,
            niacin,
            phenylalanine,
            phosphorus,
            polyunsaturated_fats,
            potassium,
            proline,
            proteins,
            retinol,
            riboflavin,
            saturated_fats,
            selenium,
            serine,
            sodium,
            thiamine,
            threonine,
            trans_fats,
            tryptophan,
            tyrosine,
            valine,
            vit_a,
            retinal = vit_a,
            vit_b1 = thiamine,
            vit_b2 = riboflavin,
            vit_b6,
            pyridoxine = vit_b6,
            vit_b12,
            cobalamine = vit_b12,
            vit_c,
            ascorbic_acid = vit_c,
            vit_d,
            vit_d2,
            vit_d3,
            vit_e,
            vit_k,
            water,
            zinc,
            alpha_carotene,
            beta_carotene,
            pantothenic_acid,
            vit_a_iu,
            vit_d_iu,
            starch,
            sucrose,
            sugar,
            theobromine,
            ala_fatty_acid,
            dha_fatty_acid,
            epa_fatty_acid,
            dpa_fatty_acid,
            total_omega_3,
            total_omega_6,
            folic_acid = folate
        }
        #endregion
    }
}

