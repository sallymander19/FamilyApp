using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FamilyAppKarenNilson
{
    class FamilyPage : ContentPage
    {
        public FamilyPage()
        {

            Title = "FamilyAppKarenNilson";
            Content = new StackLayout
            {
                //VerticalOptions = LayoutOptions.Center,
                Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            FormattedText = new FormattedString

                            {
                            Spans =
                            {
                                 new Span
                                    {
                                        Text = "My Father" + Environment.NewLine + "His name is "
                                    },
                                 new Span
                                 {
                                        Text="John Nilson",
                                        FontAttributes = FontAttributes.Bold
                                 },
                                 new Span
                                 {
                                     Text = ". He is 58 years old. He is a recruiter in the IT industry. He loves snowmobiling in the winter and camping in the summer."
                                 }
                                 }
                            }
                            },

                                                         new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            FormattedText = new FormattedString

                            {
                            Spans =
                            {
                                 new Span
                                 {
                                      Text = "My Mother" + Environment.NewLine + "Her name is "
                                  },
                                 new Span
                                 {
                                     Text = "Sue Nilson",
                                     FontAttributes = FontAttributes.Bold
                                 },
                                 new Span
                                 {
                                       Text = ". She is 56 years old. She works in insurance as a claims analyst. She also loves snowmobiling and camping along with baking."
                                 }
                                 }
                            }
                                                         },
                                                                                 new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            FormattedText = new FormattedString

                            {
                            Spans =
                            {
                                 new Span
                                 {
                                      Text = "My Sister" + Environment.NewLine + "Her name is "
                                  },
                                 new Span
                                 {
                                     Text = "Kristen Angell",
                                     FontAttributes = FontAttributes.Bold
                                 },
                                 new Span
                                 {
                                     Text = ". She is married to her husband Dave, and has 4 children. 2 boys and 2 girls. She is a stay at home mom."
                                 }
                                 }
                            }
                                                                                 },
                                                                                                         new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            FormattedText = new FormattedString

                            {
                            Spans =
                            {
                                 new Span
                                 {
                                      Text = "My Brother" + Environment.NewLine + "His name is "
                                  },
                                 new Span
                                 {
                                     Text = "Johnny Nilson",
                                     FontAttributes = FontAttributes.Bold
                                 },
                                 new Span
                                 {
                                      Text = ". He just bought his first house and is in the process of renovating it. He loves riding his motorcyle. He is a diesel mechanic but went to school for woodworking and cabinet making."
                                 }

                             }
                             }

        }
        }
            };
        }
    }

}