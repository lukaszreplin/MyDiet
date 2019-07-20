using MyDiet.DTO.Ingredients;
using MyDiet.ViewModels;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MyDiet.Ingredients.ViewModels
{
    public class IngredientsWindowViewModel : BaseViewModel
    {
        public IngredientsWindowViewModel()
        {
            Ingredients = new ObservableCollection<IngredientForList>()
            {
                new IngredientForList() { Name = "Łosoś" },
                new IngredientForList() { Name = "Chleb pełnoziarnisty" },
                new IngredientForList() { Name = "Sól himalajska" }
            };
        }

        private ObservableCollection<IngredientForList> ingredients;
        public ObservableCollection<IngredientForList> Ingredients
        {
            get { return ingredients; }
            set { SetProperty(ref ingredients, value); }
        }
    }
}
