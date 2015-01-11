using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace QuestForJoy
{
	public class MainPage : ContentPage
	{	
		Dictionary<string, Scripture> dictionary =
			new Dictionary<string, Scripture>();
/*
		string [] dKey = new string[] {
			"Isaiah 43:6–7", 
			"1 Corinthians 10:31", 
			"Romans 3:23",
			"Romans 6:23", 
			"1 Timothy 1:15", 
			"Acts 3:19; 16:31", 
			"What should you do?"};
*/
		string [] dKey = new string[] {
			"1) God created us for his glory", 
			"2) Every human should live for God's glory", 
			"3) All of us have failed to glorify God as we should",
			"4) All of us are subject to God's just condemnation", 
			"5) God sent his only son Jesus to provide eternal life and joy", 
			"6) The benefits purchased by the death of Christ belong to those who repent and trust him", 
			"What should you do?"};

		ScrollView scroll;
		StackLayout stack;

		public MainPage ()
		{
			int i = 0;

			//InitializeComponent ();

			dictionary.Add(dKey[i++], 
				new Scripture("Isaiah 43:6–7", 
					"1) God created us for his glory", 
					"Bring my sons from afar and my daughters from the ends of the earth … whom I created for my glory\n\nIsaiah 43:6–7 (ESV)",
					"God made us to magnify his greatness - the way telescopes magnify stars. He created us to put his goodness and truth and beauty and wisdom and justice on display. The greatest display of God's glory comes from deep delight in all that he is. This means that God gets the praise and we get the pleasure. God created us so that he is most glorified in us when we are most satisfied in him."));

			dictionary.Add(dKey[i++], 
				new Scripture("1 Corinthians 10:31", 
					"2) Every human should live for God\'s glory", 
					"So, whether you eat or drink, or whatever you do, do all to the glory of God\n\n1 Corinthians 10:31 (ESV)",
					"If God made us for his glory, it is clear that we should live for his glory. Our duty comes from his design. So our first obligation is to show God's value by being satisfied with all that he is for us. This is the essence of loving God (Matthew 22:37) and trusting him (1 John 5:3-4) and being thankful to him (Psalm 100:2-4) It is the root of all true obedience, especially loving others (Colossians 1:4-5)."));

			dictionary.Add(dKey[i++], 
				new Scripture("Romans 3:23", 
					"3) All of us have failed to glorify God as we should", 
					"All have sinned and fall short of the glory of God\n\nRomans 3:23 (ESV)",
					"What does it mean to \"fall short of the glory of God?\" It means that none of us has trusted and treasured God the way we should. We have not been satisfied with his greatness and walked in his ways. We have sought our satisfaction in other things, and treated them as more valuable than God, which is the essence of idolatry (Romans 1:21-23). Since sin came into the world we have all been deeply resistant to having God as our all-satisfying treasure (Ephesians 2:3). This is an appalling offense to the greatness of God (Jeremiah 2:12-13)."));

			dictionary.Add(dKey[i++], 
				new Scripture("Romans 6:23", 
					"4) All of us are subject to God\'s just condemnation", 
					"The wages of sin are death...\n\nRomans 6:23 (ESV)",
					"We have all belittled the glory of God. How? By preferring other things above him. By our ingratitude, distrust and disobedience. So God is just in shutting us out from the enjoyment of his glory forever. \"They will suffer the punishment of eternal destruction and exclusion from the presence of the Lord and from the glory of his might\" (2 Thessalonians 1:9).\n\nThe word \"hell\" is used in the New Testament fourteen times (see below)—twelve times by Jesus himself. It is not a myth created by dismal and angry preachers. It is a solemn warning from the Son of God who died to deliver sinners from its curse. We ignore it at great risk.\n\nIf the Bible stopped here in its analysis of the human condition, we would be doomed to a hopeless future. However, this is not where it stops...\n\n\nAppearances of the word \"hell\" in the New Testament\n\nBut I tell you that anyone who is angry with his brother will be subject to judgment. Again, anyone who says to his brother, `Raca,' is answerable to the Sanhedrin. But anyone who says, `You fool!' will be in danger of the fire of hell. (Matthew 5:22 Jesus speaking)\n\nIf your right eye causes you to sin, gouge it out and throw it away. It is better for you to lose one part of your body than for your whole body to be thrown into hell. (Matthew 5:29 Jesus speaking)\n\nAnd if your right hand causes you to sin, cut it off and throw it away. It is better for you to lose one part of your body than for your whole body to go into hell. (Matthew 5:30 Jesus speaking)\n\nDo not be afraid of those who kill the body but cannot kill the soul. Rather, be afraid of the One who can destroy both soul and body in hell. (Matthew 10:28 Jesus speaking)\n\nAnd if your eye causes you to sin, gouge it out and throw it away. It is better for you to enter life with one eye than to have two eyes and be thrown into the fire of hell. (Matthew 18:9 Jesus speaking)\n\n\"Woe to you, teachers of the law and Pharisees, you hypocrites! You travel over land and sea to win a single convert, and when he becomes one, you make him twice as much a son of hell as you are. (Matthew 23:15 Jesus speaking)\n\n\"You snakes! You brood of vipers! How will you escape being condemned to hell? (Matthew 23:33 Jesus speaking)\n\nIf your hand causes you to sin, cut it off. It is better for you to enter life maimed than with two hands to go into hell, where the fire never goes out. (Mark 9:43 Jesus speaking)\n\nAnd if your foot causes you to sin, cut it off. It is better for you to enter life crippled than to have two feet and be thrown into hell. (Mark 9:45 Jesus speaking)\n\nAnd if your eye causes you to sin, pluck it out. It is better for you to enter the kingdom of God with one eye than to have two eyes and be thrown into hell, (Mark 9:47 Jesus speaking)\n\nBut I will show you whom you should fear: Fear him who, after the killing of the body, has power to throw you into hell. Yes, I tell you, fear him. (Luke 12:5 Jesus speaking)\n\nIn hell, where he was in torment, he looked up and saw Abraham far away, with Lazarus by his side. (Luke 16:23 Jesus speaking)\n\nThe tongue also is a fire, a world of evil among the parts of the body. It corrupts the whole person, sets the whole course of his life on fire, and is itself set on fire by hell. (James 3:6 James speaking).\n\nFor if God did not spare angels when they sinned, but sent them to hell, putting them into gloomy dungeons to be held for judgment; (2 Peter 2:4 Peter speaking)"));

			dictionary.Add (dKey[i++], 
				new Scripture("1 Timothy 1:15", 
					"5) God sent his only son Jesus to provide eternal life and joy", 
					"The saying is trustworthy and deserving of full acceptance, that Christ Jesus came into the world to save sinners\n\n1 Timothy 1:15 (ESV)",
					"The good news is that Christ died for sinners like us. And he rose physically from the dead to validate the saving power of his death and to open the gates of eternal life and joy (1 Corinthians 15:20). This means God can acquit guilty sinners and still be just (Romans 3:25-26). \"For Christ died for sins once for all, the righteous for the unrighteous, to bring us to God\" (1 Peter 3:18). Coming home to God is where all deep and lasting satisfaction is found."));

			dictionary.Add (dKey[i++], 
				new Scripture("Acts 3:19; 16:31", 
					"6) The benefits purchased by the death of Christ belong to those who repent and trust him", 
					"Repent therefore, and turn again, that your sins may be blotted out\n\nActs 3:19 (ESV)\n\nBelieve in the Lord Jesus and you will be saved\n\nActs 16:31 (ESV)",
					"\"Repent\" means to turn from all the deceitful promises of sin. \"Faith\" means being satisfied with all that God promises to be for us in Jesus. \"He who believes in me,\" Jesus says, \"shall never thirst\" (John 6:35). We do not earn our salvation. We cannot merit it (Romans 4:4-5). It is by grace through faith (Ephesians 2:8-9). It is a free gift (Romans 3:24). We will have it if we cherish it above all things (Matthew 13:44). When we do that, God's aim in creation is accomplished: He is glorified in us and we are satisfied in him - forever."));

			dictionary.Add (dKey[i++], 
				new Scripture("",
					"What should you do?",
					"Does this make sense to you?\n\nDo you desire the kind of gladness that comes from being satisfied with all that God is for you in Jesus? If so, then God is at work in your life.",
					"What should you do?\n\nTurn from the deceitful promises of sin. Call upon Jesus to save you from the guilt and punishment and bondage. \"All who call upon the name of the Lord will be saved\" (Romans 10:13). Start banking your hope on all that God is for you in Jesus. Break the power of sin's promises by faith in the superior satisfaction of God's promises. Begin reading the Bible to find his precious and very great promises, which can set you free (2 Peter 1:3-4). Find a Bible-believing church and begin to worship and grow together with other people who treasure Christ above all things (Philippians 3:7).\n\nThe best news in the world is that there is no necessary conflict between our happiness and God's holiness. Being satisfied with all that God is for us in Jesus magnifies him as a great Treasure.\n\nYou make known to me the path of life; in your presence there is fullness of joy; at your right hand are pleasures forevermore. (Psalm 16:11)\n\n\n©2015 Desiring God Foundation. Used by Permission.\n\nAll Scripture quotations, unless otherwise indicated, are taken from The Holy Bible, English Standard Version. Copyright ©2001 by http://www.crosswaybibles.org Crossway Bibles, a publishing ministry of Good News Publishers. Used by permission. All rights reserved."));

			stack = new StackLayout ();
			scroll = new ScrollView ();

			stack.Padding = 20;
			stack.Spacing = 10;

			// Add heading
			Label heading = new Label { Text = "Quest for Joy (six Biblical truths)", 
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				FontAttributes = FontAttributes.Bold };
			stack.Children.Add (heading);

			heading = new Label { Text = "Did you know that God commands us to seek our happiness?", 
				HorizontalOptions = LayoutOptions.CenterAndExpand };
			stack.Children.Add (heading);

			heading = new Label { Text = "Delight yourself in the LORD and he will give you the desires of your heart.\nPsalm 37:4 (ESV)", 
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				FontAttributes = FontAttributes.Italic };
			stack.Children.Add (heading);

			// Add labels with tap gesture recognizers
			var tapGestureRecognizer = new TapGestureRecognizer();
			tapGestureRecognizer.Tapped +=(s,e)=>OnLabelTapped(s,e);

			Label label;
			for (int j=0; j<i; j++) {
				label = new Label { Text = dictionary[dKey[j]].Heading };
				//				add.Clicked += OnButtonClicked;
				label.GestureRecognizers.Add(tapGestureRecognizer);
				stack.Children.Add (label);
			}

/*
			Button add = new Button { Text = dictionary["What should you do?"].Heading() };
			add.Clicked += OnButtonClicked;
			stack.Children.Add (add);
*/
			scroll.Content = stack;
			Content = scroll;

		}

		async void OnLabelTapped(object sender, EventArgs args)
		{
			Label l = (Label)sender;
			await this.Navigation.PushAsync(new DetailPage(dictionary[l.Text]));
		}

		async void OnButtonClicked(object sender, EventArgs args)
		{
			Button button = (Button)sender;

			// Navigate to a new page to display the verse
			await this.Navigation.PushAsync(new DetailPage(dictionary[button.Text]));
		}
	}
}

