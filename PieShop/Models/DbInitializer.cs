﻿using System.Collections.Generic;
using System.Linq;
using PieShop.Auth;

namespace PieShop.Models
{
	public static class DbInitializer
	{
		private static Dictionary<string, Category> _categories;

		public static Dictionary<string, Category> Categories
		{
			get
			{
				if (_categories == null)
				{
					var genresList = new[]
					{
						new Category{CategoryName="Fruit pies", Description="All-fruity pies"},
						new Category{CategoryName="Cheese cakes", Description="Cheesy all the way"},
						new Category{CategoryName="Seasonal pies", Description="Get in the mood for a seasonal pie"}
					};

					_categories = new Dictionary<string, Category>();

					foreach (Category genre in genresList)
					{
						_categories.Add(genre.CategoryName, genre);
					}
				}

				return _categories;
			}
		}

		public static void Seed(AppDbContext appDbContext)
		{
			if (!appDbContext.Categories.Any())
			{
				appDbContext.AddRange(Categories.Select(category => category.Value));
			}

			if (!appDbContext.Pies.Any())
			{

				appDbContext.AddRange
				(
					new Pie
					{
						Name = "Apple Pie",
						Price = 12.95M,
						ShortDescription = "Our famous apple pies!",
						LongDescription =
							"Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragйe brownie. Lollipop cotton candy cake bear claw oat cake. Dragйe candy canes dessert tart. Marzipan dragйe gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragйe croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragйe gummies.",
						Category = Categories["Fruit pies"],
						ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
						InStock = true,
						IsPieOfTheWeek = true,
						ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
						AllergyInformation = ""
					},
					new Pie
					{
						Name = "Blueberry Cheese Cake",
						Price = 18.95M,
						ShortDescription = "You'll love it!",
						LongDescription =
							"Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragйe brownie. Lollipop cotton candy cake bear claw oat cake. Dragйe candy canes dessert tart. Marzipan dragйe gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragйe croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragйe gummies.",
						Category = Categories["Cheese cakes"],
						ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
						InStock = true,
						IsPieOfTheWeek = false,
						ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
						AllergyInformation = ""
					},
					new Pie
					{
						Name = "Cheese Cake",
						Price = 18.95M,
						ShortDescription = "Plain cheese cake. Plain pleasure.",
						LongDescription =
							"Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragйe brownie. Lollipop cotton candy cake bear claw oat cake. Dragйe candy canes dessert tart. Marzipan dragйe gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragйe croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragйe gummies.",
						Category = Categories["Cheese cakes"],
						ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg",
						InStock = true,
						IsPieOfTheWeek = false,
						ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",
						AllergyInformation = ""
					},
					new Pie
					{
						Name = "Cherry Pie",
						Price = 15.95M,
						ShortDescription = "A summer classic!",
						LongDescription =
							"Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragйe brownie. Lollipop cotton candy cake bear claw oat cake. Dragйe candy canes dessert tart. Marzipan dragйe gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragйe croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragйe gummies.",
						Category = Categories["Fruit pies"],
						ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg",
						InStock = true,
						IsPieOfTheWeek = false,
						ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg",
						AllergyInformation = ""
					},
					new Pie
					{
						Name = "Christmas Apple Pie",
						Price = 13.95M,
						ShortDescription = "Happy holidays with this pie!",
						LongDescription =
							"Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragйe brownie. Lollipop cotton candy cake bear claw oat cake. Dragйe candy canes dessert tart. Marzipan dragйe gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragйe croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragйe gummies.",
						Category = Categories["Seasonal pies"],
						ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg",
						InStock = true,
						IsPieOfTheWeek = false,
						ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg",
						AllergyInformation = ""
					},
					new Pie
					{
						Name = "Cranberry Pie",
						Price = 17.95M,
						ShortDescription = "A Christmas favorite",
						LongDescription =
							"Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragйe brownie. Lollipop cotton candy cake bear claw oat cake. Dragйe candy canes dessert tart. Marzipan dragйe gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragйe croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragйe gummies.",
						Category = Categories["Seasonal pies"],
						ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg",
						InStock = true,
						IsPieOfTheWeek = false,
						ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg",
						AllergyInformation = ""
					},
					new Pie
					{
						Name = "Peach Pie",
						Price = 15.95M,
						ShortDescription = "Sweet as peach",
						LongDescription =
							"Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragйe brownie. Lollipop cotton candy cake bear claw oat cake. Dragйe candy canes dessert tart. Marzipan dragйe gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragйe croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragйe gummies.",
						Category = Categories["Fruit pies"],
						ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg",
						InStock = false,
						IsPieOfTheWeek = false,
						ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg",
						AllergyInformation = ""
					},
					new Pie
					{
						Name = "Pumpkin Pie",
						Price = 12.95M,
						ShortDescription = "Our Halloween favorite",
						LongDescription =
							"Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragйe brownie. Lollipop cotton candy cake bear claw oat cake. Dragйe candy canes dessert tart. Marzipan dragйe gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragйe croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragйe gummies.",
						Category = Categories["Seasonal pies"],
						ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg",
						InStock = true,
						IsPieOfTheWeek = true,
						ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg",
						AllergyInformation = ""
					},
					new Pie
					{
						Name = "Rhubarb Pie",
						Price = 15.95M,
						ShortDescription = "My God, so sweet!",
						LongDescription =
							"Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragйe brownie. Lollipop cotton candy cake bear claw oat cake. Dragйe candy canes dessert tart. Marzipan dragйe gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragйe croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragйe gummies.",
						Category = Categories["Fruit pies"],
						ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg",
						InStock = true,
						IsPieOfTheWeek = true,
						ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
						AllergyInformation = ""
					},
					new Pie
					{
						Name = "Strawberry Pie",
						Price = 15.95M,
						ShortDescription = "Our delicious strawberry pie!",
						LongDescription =
							"Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragйe brownie. Lollipop cotton candy cake bear claw oat cake. Dragйe candy canes dessert tart. Marzipan dragйe gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragйe croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragйe gummies.",
						Category = Categories["Fruit pies"],
						ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
						InStock = true,
						IsPieOfTheWeek = false,
						ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
						AllergyInformation = ""
					},
					new Pie
					{
						Name = "Strawberry Cheese Cake",
						Price = 18.95M,
						ShortDescription = "You'll love it!",
						LongDescription =
							"Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragйe brownie. Lollipop cotton candy cake bear claw oat cake. Dragйe candy canes dessert tart. Marzipan dragйe gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragйe croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragйe gummies.",
						Category = Categories["Cheese cakes"],
						ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg",
						InStock = false,
						IsPieOfTheWeek = false,
						ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg",
						AllergyInformation = ""
					}
				);

				appDbContext.SaveChanges();
			}
		}
	}
}