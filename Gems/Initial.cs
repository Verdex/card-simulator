

using System;

namespace CardSimulator.Gems
{
    public static class Initial
    {
        public static Bonus[] Bonuses = new [] {
            new Bonus( 3, Tuple.Create( 3, Gem.Amethyst ), 
                          Tuple.Create( 3, Gem.Sapphire ),
                          Tuple.Create( 3, Gem.Diamond ) ),

            new Bonus( 3, Tuple.Create( 3, Gem.Amethyst ), 
                          Tuple.Create( 3, Gem.Ruby ),
                          Tuple.Create( 3, Gem.Diamond ) ),

            new Bonus( 3, Tuple.Create( 3, Gem.Emerald ), 
                          Tuple.Create( 3, Gem.Sapphire ),
                          Tuple.Create( 3, Gem.Ruby ) ),

            new Bonus( 3, Tuple.Create( 3, Gem.Amethyst ), 
                          Tuple.Create( 3, Gem.Ruby ),
                          Tuple.Create( 3, Gem.Emerald ) ),

            new Bonus( 3, Tuple.Create( 3, Gem.Emerald ), 
                          Tuple.Create( 3, Gem.Sapphire ),
                          Tuple.Create( 3, Gem.Diamond ) ),

            new Bonus( 3, Tuple.Create( 4, Gem.Sapphire ), 
                          Tuple.Create( 4, Gem.Diamond ) ),

            new Bonus( 3, Tuple.Create( 4, Gem.Amethyst ), 
                          Tuple.Create( 4, Gem.Diamond ) ),

            new Bonus( 3, Tuple.Create( 4, Gem.Amethyst ), 
                          Tuple.Create( 4, Gem.Ruby ) ),

            new Bonus( 3, Tuple.Create( 4, Gem.Ruby ), 
                          Tuple.Create( 4, Gem.Emerald ) ),

            new Bonus( 3, Tuple.Create( 4, Gem.Sapphire ), 
                          Tuple.Create( 4, Gem.Emerald ) ),
        };

        public static Card[] DeckOne = 
        new [] { new Card( 0, Gem.Diamond, new [] { Tuple.Create( 2, Gem.Sapphire )
                                                  , Tuple.Create( 2, Gem.Emerald )
                                                  , Tuple.Create( 1, Gem.Amethyst )
                                                  } )
               , new Card( 0, Gem.Emerald, new [] { Tuple.Create( 3, Gem.Ruby ) } )
               , new Card( 0, Gem.Emerald, new [] { Tuple.Create( 1, Gem.Diamond )
                                                  , Tuple.Create( 1, Gem.Sapphire )
                                                  , Tuple.Create( 1, Gem.Ruby ) 
                                                  , Tuple.Create( 1, Gem.Amethyst )
                                                  } )
               , new Card( 0, Gem.Ruby, new [] { Tuple.Create( 1, Gem.Diamond )
                                               , Tuple.Create( 1, Gem.Sapphire )
                                               , Tuple.Create( 1, Gem.Emerald )
                                               , Tuple.Create( 1, Gem.Amethyst )
                                               } )
               , new Card( 0, Gem.Amethyst, new [] { Tuple.Create( 2, Gem.Diamond )
                                                   , Tuple.Create( 2, Gem.Emerald )
                                                   } )
               , new Card( 1, Gem.Diamond, new [] { Tuple.Create( 4, Gem.Emerald ) } )
               , new Card( 0, Gem.Diamond, new [] { Tuple.Create( 1, Gem.Sapphire )
                                                  , Tuple.Create( 2, Gem.Emerald )
                                                  , Tuple.Create( 1, Gem.Ruby )
                                                  , Tuple.Create( 1, Gem.Amethyst )
                                                  } )
               , new Card( 0, Gem.Ruby, new [] { Tuple.Create( 3, Gem.Diamond ) } )
               , new Card( 0, Gem.Diamond, new [] { Tuple.Create( 3, Gem.Sapphire ) } )
               , new Card( 1, Gem.Amethyst, new [] { Tuple.Create( 4, Gem.Sapphire ) } )
               , new Card( 0, Gem.Amethyst, new [] { Tuple.Create( 3, Gem.Emerald ) } )
               , new Card( 1, Gem.Ruby, new [] { Tuple.Create( 4, Gem.Diamond ) } )
               , new Card( 0, Gem.Sapphire, new [] { Tuple.Create( 2, Gem.Emerald )
                                                   , Tuple.Create( 2, Gem.Amethyst )
                                                   } )
               , new Card( 0, Gem.Ruby, new [] { Tuple.Create( 2, Gem.Diamond )
                                               , Tuple.Create( 1, Gem.Sapphire )
                                               , Tuple.Create( 1, Gem.Emerald )
                                               , Tuple.Create( 1, Gem.Amethyst )
                                               } )
               , new Card( 0, Gem.Sapphire, new [] { Tuple.Create( 1, Gem.Sapphire )
                                                   , Tuple.Create( 3, Gem.Emerald )
                                                   , Tuple.Create( 1, Gem.Ruby )
                                                   } )
               , new Card( 0, Gem.Sapphire, new [] { Tuple.Create( 1, Gem.Diamond )
                                                   , Tuple.Create( 1, Gem.Emerald )
                                                   , Tuple.Create( 1, Gem.Ruby )
                                                   , Tuple.Create( 1, Gem.Amethyst )
                                                   } )
               , new Card( 0, Gem.Diamond, new [] { Tuple.Create( 1, Gem.Sapphire )
                                                  , Tuple.Create( 1, Gem.Emerald )
                                                  , Tuple.Create( 1, Gem.Ruby )
                                                  , Tuple.Create( 1, Gem.Amethyst )
                                                  } )
               , new Card( 0, Gem.Ruby, new [] { Tuple.Create( 1, Gem.Diamond )
                                               , Tuple.Create( 1, Gem.Ruby )
                                               , Tuple.Create( 3, Gem.Amethyst )
                                               } )
               , new Card( 0, Gem.Amethyst, new [] { Tuple.Create( 1, Gem.Diamond )
                                                   , Tuple.Create( 1, Gem.Sapphire )
                                                   , Tuple.Create( 1, Gem.Emerald )
                                                   , Tuple.Create( 1, Gem.Ruby )
                                                   } )
               , new Card( 0, Gem.Emerald, new [] { Tuple.Create( 1, Gem.Sapphire )
                                                  , Tuple.Create( 2, Gem.Ruby )
                                                  , Tuple.Create( 2, Gem.Amethyst )
                                                  } )
               , new Card( 0, Gem.Amethyst, new [] { Tuple.Create( 2, Gem.Diamond )
                                                   , Tuple.Create( 2, Gem.Sapphire )
                                                   , Tuple.Create( 1, Gem.Ruby )
                                                   } )
               , new Card( 0, Gem.Emerald, new [] { Tuple.Create( 1, Gem.Diamond )
                                                  , Tuple.Create( 3, Gem.Sapphire )
                                                  , Tuple.Create( 1, Gem.Emerald )
                                                  } )
               , new Card( 0, Gem.Emerald, new [] { Tuple.Create( 2, Gem.Sapphire )
                                                  , Tuple.Create( 2, Gem.Ruby )
                                                  } )
               , new Card( 0, Gem.Emerald, new [] { Tuple.Create( 2, Gem.Diamond )
                                                  , Tuple.Create( 1, Gem.Sapphire )
                                                  } )
               , new Card( 0, Gem.Diamond, new [] { Tuple.Create( 3, Gem.Diamond )
                                                  , Tuple.Create( 1, Gem.Sapphire )
                                                  , Tuple.Create( 1, Gem.Amethyst )
                                                  } )
               , new Card( 0, Gem.Diamond, new [] { Tuple.Create( 2, Gem.Sapphire )
                                                  , Tuple.Create( 2, Gem.Amethyst )
                                                  } )
               , new Card( 0, Gem.Sapphire, new [] { Tuple.Create( 1, Gem.Diamond )
                                                   , Tuple.Create( 2, Gem.Amethyst )
                                                   } )
               , new Card( 1, Gem.Sapphire, new [] { Tuple.Create( 4, Gem.Ruby ) } )
               , new Card( 0, Gem.Sapphire, new [] { Tuple.Create( 1, Gem.Diamond )
                                                   , Tuple.Create( 1, Gem.Emerald )
                                                   , Tuple.Create( 2, Gem.Ruby )
                                                   , Tuple.Create( 1, Gem.Amethyst )
                                                   } )
               , new Card( 0, Gem.Ruby, new [] { Tuple.Create( 2, Gem.Diamond )
                                               , Tuple.Create( 2, Gem.Ruby )
                                               } )
               , new Card( 0, Gem.Ruby, new [] { Tuple.Create( 2, Gem.Diamond )
                                               , Tuple.Create( 1, Gem.Emerald )
                                               , Tuple.Create( 2, Gem.Amethyst )
                                               } )
               , new Card( 0, Gem.Ruby, new [] { Tuple.Create( 2, Gem.Sapphire )
                                               , Tuple.Create( 1, Gem.Emerald )
                                               } )
               , new Card( 0, Gem.Amethyst, new [] { Tuple.Create( 1, Gem.Diamond )
                                                   , Tuple.Create( 2, Gem.Sapphire )
                                                   , Tuple.Create( 1, Gem.Emerald )
                                                   , Tuple.Create( 1, Gem.Ruby )
                                                   } ) 
               , new Card( 0, Gem.Amethyst, new [] { Tuple.Create( 2, Gem.Emerald )
                                                   , Tuple.Create( 1, Gem.Ruby ) 
                                                   } )
               , new Card( 0, Gem.Diamond, new [] { Tuple.Create( 2, Gem.Ruby )
                                                  , Tuple.Create( 1, Gem.Amethyst )
                                                  } )
               , new Card( 0, Gem.Sapphire, new [] { Tuple.Create( 1, Gem.Diamond )
                                                   , Tuple.Create( 2, Gem.Emerald )
                                                   , Tuple.Create( 2, Gem.Ruby )
                                                   } )
               , new Card( 0, Gem.Emerald, new [] { Tuple.Create( 1, Gem.Diamond )
                                                  , Tuple.Create( 1, Gem.Sapphire )
                                                  , Tuple.Create( 1, Gem.Ruby )
                                                  , Tuple.Create( 2, Gem.Amethyst )
                                                  } )
               , new Card( 1, Gem.Emerald, new [] { Tuple.Create( 4, Gem.Amethyst ) } )
               , new Card( 0, Gem.Sapphire, new [] { Tuple.Create( 3, Gem.Amethyst ) } )
               , new Card( 0, Gem.Amethyst, new [] { Tuple.Create( 1, Gem.Emerald )
                                                   , Tuple.Create( 3, Gem.Ruby )
                                                   , Tuple.Create( 1, Gem.Amethyst ) 
                                                   } )

               };
        public static Card[] DeckTwo = 
            new [] { new Card( 3, Gem.Amethyst, new [] { Tuple.Create( 6, Gem.Amethyst ) } )
                   , new Card( 2, Gem.Amethyst, new [] { Tuple.Create( 1, Gem.Sapphire )
                                                       , Tuple.Create( 4, Gem.Emerald )
                                                       , Tuple.Create( 2, Gem.Ruby )
                                                       } )
                   , new Card( 1, Gem.Emerald, new [] { Tuple.Create( 2, Gem.Diamond )
                                                      , Tuple.Create( 3, Gem.Sapphire )
                                                      , Tuple.Create( 2, Gem.Amethyst )
                                                      } )
                   , new Card( 1, Gem.Ruby, new [] { Tuple.Create( 3, Gem.Sapphire )
                                                   , Tuple.Create( 2, Gem.Ruby )
                                                   , Tuple.Create( 3, Gem.Amethyst )
                                                   } )
                   , new Card( 2, Gem.Ruby, new [] { Tuple.Create( 5, Gem.Amethyst ) } )
                   , new Card( 1, Gem.Ruby, new [] { Tuple.Create( 2, Gem.Diamond )
                                                   , Tuple.Create( 2, Gem.Ruby )
                                                   , Tuple.Create( 3, Gem.Amethyst ) 
                                                   } )
                   , new Card( 3, Gem.Emerald, new [] { Tuple.Create( 6, Gem.Emerald ) } )
                   , new Card( 2, Gem.Sapphire, new [] { Tuple.Create( 5, Gem.Diamond )
                                                       , Tuple.Create( 3, Gem.Sapphire )
                                                       } )
                   , new Card( 2, Gem.Emerald, new [] { Tuple.Create( 5, Gem.Sapphire )
                                                      , Tuple.Create( 3, Gem.Emerald )
                                                      } )
                   , new Card( 2, Gem.Ruby, new [] { Tuple.Create( 3, Gem.Diamond )
                                                   , Tuple.Create( 5, Gem.Amethyst )
                                                   } )
                   , new Card( 2, Gem.Amethyst, new [] { Tuple.Create( 5, Gem.Emerald )
                                                       , Tuple.Create( 3, Gem.Ruby )
                                                       } )
                   , new Card( 1, Gem.Sapphire, new [] { Tuple.Create( 2, Gem.Sapphire )
                                                       , Tuple.Create( 3, Gem.Emerald )
                                                       , Tuple.Create( 3, Gem.Amethyst )
                                                       } )
                   , new Card( 1, Gem.Amethyst, new [] { Tuple.Create( 3, Gem.Diamond )
                                                       , Tuple.Create( 3, Gem.Emerald )
                                                       , Tuple.Create( 2, Gem.Amethyst )
                                                       } )
                   , new Card( 1, Gem.Amethyst, new [] { Tuple.Create( 3, Gem.Diamond )
                                                       , Tuple.Create( 2, Gem.Sapphire )
                                                       , Tuple.Create( 2, Gem.Emerald )
                                                       } )
                   , new Card( 2, Gem.Sapphire, new [] { Tuple.Create( 2, Gem.Diamond )
                                                       , Tuple.Create( 1, Gem.Ruby )
                                                       , Tuple.Create( 4, Gem.Amethyst )
                                                       } )
                   , new Card( 1, Gem.Sapphire, new [] { Tuple.Create( 2, Gem.Sapphire )
                                                       , Tuple.Create( 2, Gem.Emerald )
                                                       , Tuple.Create( 3, Gem.Ruby )
                                                       } )
                   , new Card( 3, Gem.Sapphire, new [] { Tuple.Create( 6, Gem.Sapphire ) } )
                   , new Card( 1, Gem.Emerald, new [] { Tuple.Create( 3, Gem.Diamond )
                                                      , Tuple.Create( 2, Gem.Emerald )
                                                      , Tuple.Create( 3, Gem.Ruby )
                                                      } )
                   , new Card( 2, Gem.Ruby, new [] { Tuple.Create( 1, Gem.Diamond )
                                                   , Tuple.Create( 4, Gem.Sapphire )
                                                   , Tuple.Create( 2, Gem.Emerald )
                                                   } )
                   , new Card( 1, Gem.Diamond, new [] { Tuple.Create( 2, Gem.Diamond )
                                                      , Tuple.Create( 3, Gem.Sapphire )
                                                      , Tuple.Create( 3, Gem.Ruby )
                                                      } )
                   , new Card( 2, Gem.Amethyst, new [] { Tuple.Create( 5, Gem.Diamond ) } )
                   , new Card( 2, Gem.Diamond, new [] { Tuple.Create( 1, Gem.Emerald )
                                                      , Tuple.Create( 4, Gem.Ruby )
                                                      , Tuple.Create( 2, Gem.Amethyst )
                                                      } )
                   , new Card( 2, Gem.Diamond, new [] { Tuple.Create( 5, Gem.Ruby ) } )
                   , new Card( 2, Gem.Emerald, new [] { Tuple.Create( 5, Gem.Emerald ) } )
                   , new Card( 3, Gem.Diamond, new [] { Tuple.Create( 6, Gem.Diamond ) } )
                   , new Card( 1, Gem.Diamond, new [] { Tuple.Create( 2, Gem.Emerald ) 
                                                      , Tuple.Create( 2, Gem.Ruby )
                                                      , Tuple.Create( 2, Gem.Amethyst )
                                                      } )
                   , new Card( 3, Gem.Ruby, new [] { Tuple.Create( 6, Gem.Ruby ) } )
                   , new Card( 2, Gem.Diamond, new [] { Tuple.Create( 5, Gem.Ruby )
                                                      , Tuple.Create( 3, Gem.Amethyst )
                                                      } )
                   , new Card( 2, Gem.Emerald, new [] { Tuple.Create( 4, Gem.Diamond )
                                                      , Tuple.Create( 2, Gem.Sapphire )
                                                      , Tuple.Create( 1, Gem.Amethyst )
                                                      } )
                   , new Card( 2, Gem.Sapphire, new [] { Tuple.Create( 5, Gem.Sapphire ) } )
                   };
        public static Card[] DeckThree = 
            new [] { new Card( 4, Gem.Amethyst, new [] { Tuple.Create( 7, Gem.Ruby ) } )
                   , new Card( 4, Gem.Ruby, new [] { Tuple.Create( 7, Gem.Emerald ) } )
                   , new Card( 4, Gem.Diamond, new [] { Tuple.Create( 3, Gem.Diamond )
                                                      , Tuple.Create( 3, Gem.Ruby )
                                                      , Tuple.Create( 6, Gem.Amethyst )
                                                      } )
                   , new Card( 4, Gem.Sapphire, new [] { Tuple.Create( 6, Gem.Diamond )
                                                       , Tuple.Create( 3, Gem.Sapphire )
                                                       , Tuple.Create( 3, Gem.Amethyst )
                                                       } )
                   , new Card( 5, Gem.Amethyst, new [] { Tuple.Create( 7, Gem.Ruby )
                                                       , Tuple.Create( 3, Gem.Amethyst )
                                                       } )
                   , new Card( 5, Gem.Ruby, new [] { Tuple.Create( 7, Gem.Emerald )
                                                   , Tuple.Create( 3, Gem.Ruby )
                                                   } )
                   , new Card( 5, Gem.Emerald, new [] { Tuple.Create( 7, Gem.Sapphire )
                                                      , Tuple.Create( 3, Gem.Emerald ) 
                                                      } )
                   , new Card( 4, Gem.Ruby, new [] { Tuple.Create( 3, Gem.Sapphire )
                                                   , Tuple.Create( 6, Gem.Emerald )
                                                   , Tuple.Create( 3, Gem.Ruby )
                                                   } )
                   , new Card( 3, Gem.Diamond, new [] { Tuple.Create( 3, Gem.Sapphire )
                                                     , Tuple.Create( 3, Gem.Emerald )
                                                     , Tuple.Create( 5, Gem.Ruby )
                                                     , Tuple.Create( 3, Gem.Amethyst )
                                                     } )
                   , new Card( 5, Gem.Diamond, new [] { Tuple.Create( 3, Gem.Diamond )
                                                      , Tuple.Create( 7, Gem.Amethyst )
                                                      } )
                    , new Card( 3, Gem.Amethyst, new [] { Tuple.Create( 3, Gem.Diamond )
                                                        , Tuple.Create( 3, Gem.Sapphire )
                                                        , Tuple.Create( 5, Gem.Emerald )
                                                        , Tuple.Create( 3, Gem.Ruby )
                                                        } )
                   , new Card( 4, Gem.Emerald, new [] { Tuple.Create( 3, Gem.Diamond )
                                                      , Tuple.Create( 6, Gem.Sapphire )
                                                      , Tuple.Create( 3, Gem.Emerald )
                                                      } ) 
                   , new Card( 3, Gem.Emerald, new [] { Tuple.Create( 5, Gem.Diamond )
                                                      , Tuple.Create( 3, Gem.Sapphire )
                                                      , Tuple.Create( 3, Gem.Ruby )
                                                      , Tuple.Create( 3, Gem.Amethyst )
                                                      } )
                   , new Card( 4, Gem.Amethyst, new [] { Tuple.Create( 3, Gem.Emerald )
                                                       , Tuple.Create( 6, Gem.Ruby )
                                                       , Tuple.Create( 3, Gem.Amethyst )
                                                       } )
                   , new Card( 3, Gem.Sapphire, new [] { Tuple.Create( 3, Gem.Diamond )
                                                       , Tuple.Create( 3, Gem.Emerald )
                                                       , Tuple.Create( 3, Gem.Ruby )
                                                       , Tuple.Create( 5, Gem.Amethyst )
                                                       } )
                   , new Card( 4, Gem.Diamond, new [] { Tuple.Create( 7, Gem.Amethyst ) } )
                   , new Card( 5, Gem.Sapphire, new [] { Tuple.Create( 7, Gem.Diamond )
                                                       , Tuple.Create( 3, Gem.Sapphire )
                                                       } )
                   , new Card( 3, Gem.Ruby, new [] { Tuple.Create( 3, Gem.Diamond )
                                                   , Tuple.Create( 5, Gem.Sapphire )
                                                   , Tuple.Create( 3, Gem.Emerald )
                                                   , Tuple.Create( 3, Gem.Amethyst )
                                                   } )
                   , new Card( 4, Gem.Emerald, new [] { Tuple.Create( 7, Gem.Sapphire ) } )
                   , new Card( 4, Gem.Sapphire, new [] { Tuple.Create( 7, Gem.Diamond ) } )
                   };
    }
}
