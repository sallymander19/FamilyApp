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
            Content = new ScrollView
            {
                Content = new StackLayout

                {
                    //VerticalOptions = LayoutOptions.Center,
                    Children = {
                                                new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            BackgroundColor = Color.Teal,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                            FormattedText = new FormattedString
                            {
                            Spans =
                            {
                                 new Span
                                    {
                                        Text = "Me" + Environment.NewLine + "My name is ",
                                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                                    },
                                 new Span
                                 {
                                        Text="Karen Nilson",
                                        ForegroundColor = Color.Navy,
                                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                                        FontAttributes = FontAttributes.Bold
                                 },
                                 new Span
                                 {
                                     Text = ". I am 34 years old. I work in Embroidery as an embroiderer and a digitizer. I am currently going to school to obtain my AAS in .NET Programming. I love music and I like to play the piano, read, and I love to collect shoes.",
                                     FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                                 }
                                 }
                            }
                            },
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            BackgroundColor = Color.Green,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                            FormattedText = new FormattedString
                            {
                            Spans =
                            {
                                 new Span
                                    {
                                        Text = "My Father" + Environment.NewLine + "His name is ",
                                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                                    },
                                 new Span
                                 {
                                        Text="John Nilson",
                                        ForegroundColor = Color.Silver,
                                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                                        FontAttributes = FontAttributes.Bold
                                 },
                                 new Span
                                 {
                                     Text = ". He is 58 years old. He is a recruiter in the IT industry. He loves snowmobiling in the winter and camping in the summer.",
                                     FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                                 }
                                 }
                            }
                            },

                            new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                            BackgroundColor = Color.Purple,
                            FormattedText = new FormattedString

                            {
                            Spans =
                            {
                                 new Span
                                 {
                                      Text = "My Mother" + Environment.NewLine + "Her name is ",
                                      FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                                  },
                                 new Span
                                 {
                                     Text = "Sue Nilson",
                                     ForegroundColor = Color.White,
                                     FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                                     FontAttributes = FontAttributes.Bold

                                 },
                                 new Span
                                 {
                                       Text = ". She is 56 years old. She works in insurance as a claims analyst. She also loves snowmobiling and camping along with baking.",
                                       FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                                 }
                                 }
                            }
                                                         },
                            new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            BackgroundColor = Color.Fuchsia,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                            FormattedText = new FormattedString

                            {
                            Spans =
                            {
                                 new Span
                                 {
                                      Text = "My Sister" + Environment.NewLine + "Her name is ",
                                      FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                                  },
                                 new Span
                                 {
                                     Text = "Kristen Angell",
                                     ForegroundColor = Color.Aqua,
                                     FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                                     FontAttributes = FontAttributes.Bold
                                 },
                                 new Span
                                 {
                                     Text = ". She is married to her husband Dave, and has 4 children. 2 boys and 2 girls. She is a stay at home mom.",
                                     FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                                 }
                                 }
                            }
                                                                                 },
                            new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            BackgroundColor = Color.Orange,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                            FormattedText = new FormattedString

                            {
                            Spans =
                            {
                                 new Span
                                 {
                                      Text = "My Brother" + Environment.NewLine + "His name is ",
                                      FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                                  },
                                 new Span
                                 {
                                     Text = "John Nilson",
                                     ForegroundColor = Color.Navy,
                                     FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                                     FontAttributes = FontAttributes.Bold
                                 },
                                 new Span
                                 {
                                      Text = ". He just bought his first house and is in the process of renovating it. He loves riding his motorcyle. He is a diesel mechanic but went to school for woodworking and cabinet making.",
                                      FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                                 }

                             }
                             }

        }
        }
                }
            };
        }
    }

}