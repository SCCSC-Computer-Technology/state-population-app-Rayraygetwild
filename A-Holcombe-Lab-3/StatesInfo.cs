using StatesClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Holcombe_Lab_3
{
    public partial class StatesInfo : Form
    {
        State[] state = new State[50];//recalling class within the class library
        public StatesInfo()
        {
            InitializeComponent();
            try//try catch
            {
             //Population class to put into listbox, textboxes, and combo box   
                state[0] = new State("Alabama (AL)", 5193088, "The crimson and white colors of the Alabama flag were officially adopted in the year 1895 by the Alabama legislature. The flag has two crimson bars in an X pattern that is similar to the St. Andrews Cross.", "Camellia", "Northern Flicker", " ", "Huntsville, Birmingham, Montgomery", "Montgomery", 66659, 2.7);
                state[1] = new State("Alaska (AK)", 737270, "The dark blue flag contains eight gold stars, seven of which form the Big Dipper and the eighth is representative of the North Star.", "Forget-me-not", "Willow Ptarmigan", " ", "Anchorage, Fairbanks, Juneau", "Juneau", 95665, 1.6);
                state[2] = new State("Arizona (AZ)", 7623818, "The magnificent setting sun flag of Arizona incorporates symbolism from both the past and the present. The yellow and red alternating stripes represent the original thirteen colonies and the star in the middle of the flag is copper in color to show Arizona’s status as the country’s largest producer of copper even today.", "Saguaro Cactus Blossom", "Cactus Wren", "Blue & Gold", " Phoenix, Tucson, Mesa", "Phoenix", 81486, 3.4);
                state[3] = new State("Arkansas (AR)", 3114791, " Arkansas’s red, white, and blue flag has a large blue diamond surrounding the word “Arkansas.” There are 25 white stars within the blue diamond, with three blue stars at the bottom of the flag, and two parallel blue stars. The star at the top of the flag stands for Arkansas's role in the Confederacy during the Civil War.", "Apple Blossom", "Northern Mockingbird", " ", "Little Rock, Fayetteville, Fort Smith ", "Little Rock", 62106, 2);
                state[4] = new State("California (CA)", 39355309, "This flag includes the grizzly bear, which stands for strength, and the red star, which is representative of the “Lone Star” of Texas. ", "California Poppy", "California Quail", "Blue and Gold", "Los Angeles, San Diego, San Jose", "Sacramento", 100149, 4.1);
                state[5] = new State("Colorado (CO)", 6012561, "Arkansas’s red, white, and blue flag has a large blue diamond surrounding the word “Arkansas.” There are 25 white stars within the blue diamond, with three blue stars at the bottom of the flag, and two parallel blue stars. The star at the top of the flag stands for Arkansas's role in the Confederacy during the Civil War. ", "Rocky Mountain Columbine", "Lark Bunting", " ", "Denver, Colorado Springs, Aurora", "Denver", 97113, 10);
                state[6] = new State("Connecticut (CT)", 3688496, " This blue flag contains a white shield with three grapevines on it. Below the shield is the state motto, “Qui transtulit Sustinet' - 'He who hath transplanted will sustain.", "Mountain Laurel", "American Robin", "   ", " Bridgeport, Stamford, New Haven", "Hartford", 96049, 2.9);
                state[7] = new State("Delaware (DE)", 1059952, "The date at the bottom of the flag is the first official state within the Union. The diamond in the center of the flag is symbolic of Thomas Jefferson’s comment that DE is a “jewel” among the states due to its location on the eastern coast of the country.", "Peach Blossom", "Blue Hen Chicken", "Colonial Blue and Buff", "Wilmington, Dover, Newark", "Dover", 87534, 3.5);
                state[8] = new State("Florida (FL)", 23462518, "The official flag of Florida contains a red, diagonal cross over a white background, and in the center is the Seal of the state. There are several symbols on the State Seal that include a Seminole Indian female, an enhanced steamboat, and a sabal palm tree.", "Orange Blossom", "Northern Mockingbird", " ", "Jacksonville, Miami, Tampa", "Tallahassee", 77735, 3);
                state[9] = new State("Georgia (GA)", 11302748, "This red, white, and blue flag contains the state’s Seal and thirteen white stars. The arch that is held up by the three columns, the words Wisdom, Justice, and Moderation, which have always appeared on banners, and finally, the soldier representing the defense of the constitution", "Cherokee Rose", "Brown Thrasher", " ", "Atlanta, Columbus, Augusta", "Atlanta", 79991, 3.4);
                state[10] = new State("Hawaii (HI)", 1432820, "The Union Jack in the corner is representative of the UK, while the eight stripes signify the USA. The eight stripes also stand for the eight main islands in the chain: Hawaii, Kahoolawe, Kauai, Lanai, Maui, Molokai, Niihau, and Oahu.", "Hibiscus", "Nene", "Island Colors", "Honolulu, East Honolulu 1, Pearl City1", "Honolulu1", 100745, 2.2);
                state[11] = new State("Idaho (ID)", 2029733, "The state flag of Idaho contains the only state seal in the country that was designed by a woman, Emma Edwards. She placed the man and woman in the seal next to one another and at equal heights. Some of the symbols include the miner, the scales (to denote liberty and justice), the trees, the shield, the stamp mill, the cornucopia, and the elk’s head.", "Mock Orange", "Mountain Bluebird", " ", "Boise, Meridian, Nampa", "Boise", 81166, 2.2);
                state[12] = new State("Illinois (IL)", 12719141, "The bald eagle pictured on the flag is representative of the United States of America and in its beak is the state motto. The word Illinois was added to the flag during the Vietnam War because it was difficult to discern its identity.", "Purple Violet", "Northern Cardinal", " ", "Chicago, Aurora, Joliet", "Springfield", 83211, 2.9);
                state[13] = new State("Indiana (IN)", 6973333, "This dark blue flag, which contains a torch in the center of the flag, is representative of those values, while the rays emanating from it show how their influence has spread. The thirteen outer stars stand for the original thirteen colonies and the five inner stars are a reference to the next fives states that will be brought into the Union. The largest star at the top of the flag, right below the name of the state, represents the state itself.", "Peony", "Northern Cardinal", "Blue and Gold", "Indianapolis, Fort Wayne, Evansville", "Indianapolis", 71959, 2.1);
                state[14] = new State("Iowa (IA)", 3238387, "The tri-color Iowa state flag has red, white, and blue colors and is representative of Iowa’s close ties to France. The white stripe in the center is indicative of the Native Americans that had roamed the land prior to it being settled by Europeans. Finally, the eagle in the center of the flag is used to symbolize Iowa’s integration within the United States of America.", "Wild Prairie Rose", "American Goldfinch", " ", "Des Moines, Cedar Rapids, Davenport", "Des Moines", 75501, 2.5);
                state[15] = new State("Kansas (KS)", 2977220, "The Kansas state flag is a dark-blue rectangle including the state seal and a sunflower. The seal, located in the center of the flag, tells the story of Kansas with its motto, “Ad Astra per Aspera,” meaning “To the Stars through Difficulties.” The thirty-four stars above the motto signify Kansas as the 34th state to be accepted into the Union. The word “Kansas” was added to the bottom of the flag in 1961.", "Sunflower", "Western Meadowlark", " ", "Wichita, Overland Park, Kansas City", "Topeka", 75514, 2.8);
                state[16] = new State("Kentucky (KY)", 4606864, "On a background of navy blue, the words “Commonwealth of Kentucky” headline the Kentucky state flag, along with two sprigs of goldenrod, the state flower. At the center of the flag, the Kentucky state seal depicts two men shaking hands, a pioneer and a statesman. The belief is that these two figures represent all men as captured in the state motto, “United We Stand, Divided We Fall.”", "Goldenrod", "Northern Cardinal", " ", "Louisville, Lexington, Bowling Green", "Frankfort", 64526, 1.9);
                state[17] = new State("Louisiana (LA)", 4618189, "On an azure background, a pelican, the state bird, feeds her three young with drops of blood gouged from her own breast, affectionately referred to as a “pelican in her piety.” Below the pelicans is Louisiana’s state motto, “Union, Justice & Confidence.”", "Magnolia", "Brown Pelican", "Blue, Gold, White", "New Orleans, Baton Rouge,  Shreveport", "Baton Rouge", 60986, 1.3);
                state[18] = new State("Maine (ME)", 1414874, "This flag consists of the Maine Coat of Arms on a blue field. The shade of blue is the same as that used in the United States flag. A farmer and a seaman represent Maine’s traditional reliance on agriculture and the sea. Above the shield and beneath the North Star is the word, “Dirigo,” the state’s motta meaning “I lead.” A banner beneath the shield bears the state’s name.", "White Pine Tassel and Cone", "Black-Capped Chickadee", " ", "Portland, Lewiston, Bangor", "Augusta", 76442, 2.3);
                state[19] = new State("Maryland (MD)", 6265347, "The Maryland state flag embodies the yellow-and-black arms of his paternal family with the red-and-white colors and cross-bottony design of his maternal family, the Crosslands.", "Black-eyed Susan", "Baltimore Oriole", " ", "", "Annapolis", 102905, 5.1);
                state[20] = new State("Massachusetts (MA)", 7154084, "The state flag, approved in its final form, consists of the Massachusetts coat of arms on both sides. On the coat of arms is an Algonquin Native American from the Massachuset tribe, who is carrying a bow and arrow pointing downward in peace. A white star by the figure’s head signifies Massachusetts as the 6th state admitted into the Union. On a blue ribbon around the shield are the Latin words meaning “By the Sword We Seek Peace, but Peace Only under Liberty,” the state motto. This motto is also reflected by the bent arm at the top of the shield holding a broadsword blade up.", "Mayflower", "Black-Capped Chickadee", "Blue - Green - Cranberry", "Boston, Worcester, Springfield", "Boston", 104828, 4.3);
                state[21] = new State("Michigan (MI)", 10127884, "The present flag consists of the coat of arms on a field of blue as required by Michigan law. The coat of arms features a bald eagle holding an olive branch and arrows on top of a shield, along with a man standing on a grassy peninsula waving with one hand while holding a rifle in the other. The shield is supported by an elk and a moose. Three state mottos encircle the coat of arms, translated from Latin to mean “From many, one”; “I will defend”; and “If you seek a pleasant peninsula, look about you.” The Michigan state flag, with its coat of arms, represents these mottos pictorially.", "Apple Blossom", "American Robin", " ", "Detroit, Grand Rapids,  Warren", "Lansing", 72389, 2.9);
                state[22] = new State("Minnesota (MN)", 5830405, "The official flag for the state of Minnesota is made up of the state seal surrounded by a wreath of flowers on a medium blue background. Three dates appear on the wreath: 1858, 1819, and 1893, the year the first official flag was adopted. A red ribbon at the top of the seal proclaims the state motto: “L’Etoile du Nord.” Surrounding the seal is a circular banner containing 19 stars. The largest star, located at the top, represents the North Star, and the word “Minnesota” is located at the bottom. The flag also displays the pink and white lady’s slipper, the state flower.", "Pink and White Ladyslipper", "Common Loon", " ", "Minneapolis, Saint Paul, Rochester", "Saint Paul", 87117, 3.3);
                state[23] = new State("Mississippi (MS)", 2954160, "This design incorporated a magnolia tree on a white field with its canton corner made up of a white star on a blue field (the Bonnie Blue flag). This flag features the Confederate battle flag in its canton, with a field of equal bars of blue, white, and red at the bottom.", "Magnolia", "Northern Mockingbird", " ", "Jackson, Gulfport, Southaven", "Jackson", 59127, 1.4);
                state[24] = new State("Missouri (MO)", 6270541, "A flag bearing the Missouri coat of arms showing a Bald Eagle with olive branches (peace) and arrows (war), a grizzly bear, and a crescent moon. On top are the words “United We Stand, Divided We Fall.” On horizontal bars of red, white, and blue (representing its French heritage), the coat of arms is supported by two more grizzly bears standing on a scroll inscribed with the words “Salus populi suprema lex esto” meaning “Let the welfare of the people be the supreme law.” Below the scroll are the Roman numerals for 1820. A band of 24 stars denotes Missouri’s induction into the union", "Hawthorn", "Eastern Bluebird", "sd", "Kansas City, Saint Louis, Springfield", "Jefferson City", 71589, 2.9);
                state[25] = new State("Montana (MT)", 1144694, "This flag consisted of the Montana state seal on a dark blue background with the words “1st Montana Inft’y U.S.V.” at the top. On the seal are a miner’s pick and shovel with the Great Falls of the Missouri River running nearby surrounded by beautiful mountain scenery. A ribbon beneath the pick and shovel displays the words “Oro y Plata” (gold and silver in Spanish). In 1981, the Montana Legislature added the word “Montana” in Roman lettering above the seal", "Bitterroot", "Western Meadowlark", " ", "Billings, Missoula, Great Falls", "Helena", 75340, 1.9);
                state[26] = new State("Nebraska (NE)", 2018006, "The Great Seal of the State charged on the center in gold and silver on a field of national blue. The state sealis represented by a steamboat on the Missouri River, a blacksmith with a hammer and anvil, and a settler’s cabin with wheat and corn in the foreground; a train on the transcontinental railroad heads for the Rocky Mountains in the background. A ribbon above the landscape bears the state motto: “Equality Before the Law.” Also on the seal are the words “Great Seal of the State of Nebraska” and “March 1st, 1867,”", "Goldenrod", "Western Meadowlark", " ", "Omaha, Lincoln, Bellevue", "Lincoln", 76376, 3.2);
                state[27] = new State("Nevada (NV)", 3282188, "On a cobalt blue background a design made up of a wreath of sagebrush (the state flower) cradling a silver star with “Nevada” circling its points. A ribbon at the top of the wreath contains the words “Battle Born” in recognition of the fact that Nevada became a state during the Civil War.", "Sagebrush", "Mountain Bluebird", "Silver and Blue", "Las Vegas, Henderson, North Las Vegas", "Carson City", 81134, 1.8);
                state[28] = new State("New Hampshire (NH)", 1415342, "The New Hampshire state flag appears with the State Seal on a deep blue background. On the seal is the frigate USS Raleigh in front of the rising sun. The Raleigh, built in 1776 as one of the first 13 warships to fight the British in the Revolutionary War, is sailing near a large gray granite boulder. (The state nickname is “the Granite State.”) Encircling the frigate are the words “Seal of the State of New Hampshire” with the date “1776” below it. A wreath of yellow laurel leaves interspersed with nine stars surrounds the seal.", "Purple Lilac", "Purple Finch", " ", "Manchester, Nashua, Concord", "Concord", 99782, 3.3);
                state[29] = new State("New Jersey (NJ)", 9548215, "The coat of arms, designed in 1777 by Pierre Eugene du Simitiere, is composed of a blue shield with three plows on it supported by two goddesses on either side. On the left, the Goddess of Liberty is holding a staff with the cap of freedom on it; Ceres, the Goddess of Agriculture, is on the right holding a cornucopia full of food. Beneath them is a blue ribbon with the state motto “Liberty and Prosperity” and the date “1776.” Above the shield is a knight’s helmet representing state sovereignty and a horse’s head denoting speed and strength.", "Violet", "American Goldfinch", "Jersey Blue and Buff", "Newark, Jersey City, Paterson", "Trenton", 104294, 3.9);
                state[30] = new State("New Mexico (NM)", 2125498, "The sun symbol contains four groups of rays at right angles with four rays in each group, with the inner rays longer than the outer ones. Four is a sacred number for the Zia Indians, repeating itself in the rays radiating from the center of the sun, which symbolizes the Circle of Life. The sun is red in the center of a yellow background, colors chosen to honor the Spanish explorers who came to Mexico in the 1500s.", "Yucca", "Greater Roadrunner", "Red and Yellow", "Albuquerque, Las Cruces, Rio Rancho", "Santa Fe", 67816, 2.8);
                state[31] = new State("New York (NY)", 20002427, "The coat of arms is to appear on a blue background as the state flag. In 1896, the. On the coat of arms, which was adopted in 1788, are two goddesses supporting a shield with a sun rising over two ships sailing the Hudson River. On the left, Liberty is dressed in blue holding a staff with the cap of freedom on it and a discarded crown at her feet, symbolizing freedom from British control. The Goddess Justice, in gold, stands on the right wearing a blindfold and holding the scale of justice. Beneath them is the state motto “Excelsior,” Latin meaning “ever upward,” on a white scroll. Above the shield is an American eagle perched on a globe showing the Western hemisphere.", "Rose", "Eastern Bluebird", " ", "New York, Buffalo, Yonkers", "Albany", 85820, 3.1);
                state[32] = new State("North Carolina (NC)", 11197968, "This red, white, and blue flag features a white star with the letters “N” and “C” in gold on either side. A gold scroll above displays the date “May 20, 1775,” commemorating the “Mecklenburg Declaration of Independence.” A scroll below has the date “April 12, 1776,” the date of the “Halifax Resolves.”", "Flowering Dogwood", "Northern Cardinal", "Red and Blue", "Charlotte, Raleigh, Greensboro", "Raleigh", 73958, 3.8);
                state[33] = new State("North Dakota (ND)", 799358, "The regimental flag carried into battle was made up of a field of deep blue with a Bald Eagle clutching an olive branch (representing peace) and arrows (representing liberty) in its claws. A shield on the bird’s breast bears 13 red and white stripes, and a ribbon in its beak displays the words “E Pluribus Unum,” meaning “Out of Many, One” in Latin. Above the eagle is a yellow fan in the shape of a sunburst containing an array of 13 yellow stars, and a red scroll beneath the eagle displays the words “North Dakota.”", "Wild Prairie Rose", "Western Meadowlark", " ", "Fargo, Bismarck, Grand Forks", "Bismarck", 77871, 1.8);
                state[34] = new State("Ohio (OH)", 11900510, "The Ohio State Flag is the only American state flag that is not rectangular in shape. The Ohio burgee is made up of a large blue triangle representing the hills and valleys of the state and five alternating red and white stripes representing its roads and waterways. Within the triangle are 17 stars around a large white circle with a red center", "Scarlet Carnation", "Northern Cardinal", " ", "Columbus, Cleveland, Cincinnati", "Columbus", 72212, 2.7);
                state[35] = new State("Oklahoma (OK)", 4123288, "This flag features an Osage Nation buffalo-skin shield with seven eagle feathers hanging from it. On the shield are an olive branch and a peace pipe, symbols of peace to Europeans and Native Americans, and six white crosses represent stars, symbolizing high ideals to Native American cultures. The shield is centered on a blue background, and the state name in white letters", "Mistletoe", "Scissor-Tailed Flycatcher", "Green and White", "Oklahoma City, Tulsa, Norman", "Oklahoma City", 66148, 2.3);
                state[36] = new State("Oregon (OR)", 4273586, "Oregon has the only state flag with a different design on each side. Both sides are navy, with gold design, and the reverse features a beaver (the state animal). The front of the flag displays the words “State of Oregon” and the date “1859” at the top and bottom with a heart-shaped shield surrounded by 33 stars. A sun, mountains, forests, and a covered wagon make up the scene on the shield, while a plow and a pickax are beneath a banner with the words “The Union.” The crest of the shield is an American eagle with two ships sailing on the Pacific Ocean below. The ships, a British ship departing and an American trade vessel arriving", "Oregon Grape", "Western Meadowlark", "Navy Blue and Gold", "Portland, Eugene, Salem", "Salem", 85220, 3.2);
                state[37] = new State("Pennsylvania (PA)", 13059432, "The Pennsylvania State Flag is composed of the State Coat of Arms on a deep blue field. Containing the elements of the State Seal, the Coat of Arms, on it, two black draft horses are supporting a shield with an American eagle as a crest and a red ribbon with the words “Virtue, Liberty and Independence” beneath it. On the shield are a ship, a plough, and three sheaves of wheat with a corn stalk and an olive branch below.", "Mountain Laurel", "Ruffed Grouse", "Blue & Gold", "Philadelphia, Pittsburgh, Allentown", "Harrisburg", 77545, 2.9);
                state[38] = new State("Rhode Island (RI)", 1114521, "On a white field is a gold anchor encircled by 13 gold stars. Beneath the anchor is the motto “Hope” in gold letters on a blue ribbon. The stars and anchor are outlined in the same blue.", "Violet", "Rhode Island Red Chicken", " ", "Providence, Warwick, Cranston", "Providence", 83504, 3.7);
                state[39] = new State("South Carolina (SC)", 5570274, "The South Carolina flag is representative of the crescent shape on the front of the caps worn by Revolutionary War soldiers from SC. The palmetto tree and the final aspect of the flag are the dark blue background.", "Yellow Jessamine", "Carolina Wren", "Indigo blue", "Charleston, Columbia, North Charleston", "Columbia", 72350, 2.4);
                state[40] = new State("South Dakota (SD)", 935094, "This official flag featured a golden sun with the words “South Dakota” above and “The Mount Rushmore State.” below, also in gold. The Seal of the State of South Dakota picturing a steamboat on a river with a farmer plowing a field in the foreground and mountains in the distance. Above the scene on a ribbon is the state motto “Under God the People Rule.”", "Pasque Flower", "Ring-Necked Pheasant", " ", "Sioux Falls, Rapid City, Aberdeen", "Pierre", 76881, 2.1);
                state[41] = new State("Tennessee (TN)", 7315076, "sCapt. Reeves utilized the stars to represent the three different regions of the state of Tennessee: West, Middle, and East. The three stars remain together due to the blue circle that encompasses them, “an indissoluble trinity” as described by the captain.d", "Iris", "Northern Mockingbird", " ", "Nashville, Memphis, Knoxville", "Nashville", 71997, 2.5);
                state[42] = new State("Texas (TX)", 31709821, "The red, white, and blue colors used for the flag represent bravery, purity, and loyalty respectively. The Lone Star flag was officially adopted in 1839 and each point of the star on the flag has been given an unofficial meaning.", "Texas Bluebonnet", "Northern Mockingbird", " ", "Houston, San Antonio, Dallas", "Austin", 79721, 3.6);
                state[43] = new State("Utah (UT)", 3538904, "Utah adopted an official state flag consisting of a gold circle around the Great Seal of Utah, centered on a dark blue background. The seal consists of the coat of arms, featuring a beehive flanked by sego lilies, the state flower. The state motto “Industry” arches above the beehive with “Utah” below. An eagle ready for flight perches on top of the coat of arms with six arrows beneath it. Two American flags flank the arms with their flagstaffs crossed to enclose two dates: 1847, and 1896. However, an error was made in 1922 placing the date beneath the arms on the Seal itself, and this design remains on the flag to this day.", "Sego Lily", "California Gull", " ", "Salt Lake City, West Valley City, West Jordan", "Salt Lake City", 96658, 4.2);
                state[44] = new State("Vermont (VT)", 644663, "A flag composed of the State Coat of Arms on a field of blue, with a large pine tree, a cow, and three sheaves of wheat, forms a landscape on the Coat of Arms with mountains rising in the background. A buck’s head forms the crest of the arms with two pine boughs on either side crossed under a red ribbon with the words “Vermont” and “Freedom and Unity” below.", "Red Clover", "Hermit Thrush", " ", "Burlington,  South Burlington, Rutland", "Burlington", 82730, 2.7);
                state[45] = new State("Virginia (VA)", 8880107, "The Virginia flag shows two figures, a female standing over a fallen male. The female, who is garbed in ancient Greek apparel, is holding both spear and sword. The male is shown wearing the uniform of a Roman soldier with a fallen crown on the ground near him. The actual flag of Virginia was not created until 1861, when the seal was placed on a dark blue flag.", "Flowering Dogwood", "Northern Cardinal", " ", "Virginia Beach, Chesapeake, Norfolk", "Richmond", 92090, 5.9);
                state[46] = new State("Washington (WA)", 8001020, "This design includes the State Seal centered on a field of deep green. The State Seal is composed of a bust of George Washington, the first American president, on an oriental blue background. The seal is encircled by the words “The Seal of the State of Washington” on a yellow background with “1889” at the bottom.", "Coast Rhododendron", "American Goldfinch", " ", "Seattle, Spokane, Tacoma", "Olympia", 99389, 6);
                state[47] = new State("West Virginia (WV)", 1766147, "West Virginia adopted an official State Seal, the central part of the West Virginia Coat of Arms, which would become the most prominent element of the state flag. The State Seal pictures a farmer and a miner standing on either side of a large boulder featuring the date “June 20, 1863” with two crossed rifles in front of them. A red liberty cap, the symbol of freedom, rests on top of the rifles. Below is a red ribbon with the state motto: “Montani Semper Liberi” which means “Mountaineers are always free” in Latin. The Seal is topped by a red ribbon with the words “State of West Virginia” and encircled by a wreath of Rhododendron maximum or “great laurel,” the state flower.", "Rhododendron", "Northern Cardinal", "Old Gold & Blue", "Charleston, Huntington, Morgantown", "Charleston", 60798, 1.9);
                state[48] = new State("Wisconsin (WI)", 5972787, "The Wisconsin State Flag features the state motto “Forward” at the top, and just below is the state animal, the badger. The sailor and miner represent the people working on water and land. The cornucopia and lead highlight the state's farm products and minerals, and a shield is featured in the center of the flag.", "Violet", "American Robin", " ", "Milwaukee, Madison, Green Bay", "Madison", 77488, 2.8);
                state[49] = new State("Wyoming (WY)", 588753, "The Wyoming State Flag has a Bison facing the hoist as bison are known to weather the harsh winter by facing into the wind. The Great Seal of the State of Wyoming serves as the heart of the flag; as well as the bison.", "Indian Paintbrush", "Western Meadowlark", " ", "Cheyenne, Casper, Gillette", "Cheyenne", 75532, 1.5);
            }
            catch (Exception bad)
            {
                MessageBox.Show("Something went wrong" + bad);
            }
        }

        private void buttExit_Click(object sender, EventArgs e)
        {
            //this closes the form
            //Configuring MessageBox
            MessageBox.Show("Exiting Form....", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void StatesInfo_Load(object sender, EventArgs e)
        {
            //populating combo box once form loads
            for (int i = 0; i < state.Length; i++)
            {
                cbState.Items.Add(state[i].Name);
            }
        }

        private void buttSelect_Click(object sender, EventArgs e)
        {
            //clear stuff method recalled
            ClearStuff();

            try//try catch
            {


                string b = "";
                if (cbState.SelectedIndex != -1)//checking what is selected in combo box to have info populated correctly
                {
                    b = cbState.Text;
                    for (int i = 0; i < cbState.Items.Count; i++)
                    {
                        if (b == state[i].Name)
                        {
                            tbFlag.Text = state[i].Flag;
                            lstbCities.Items.Add(state[i].Cities);
                            tbBird.Text = state[i].Bird;
                            tbCapitol.Text = state[i].Capitol;
                            tbColor.Text = state[i].Colors;
                            tbFlower.Text = state[i].Flower;
                            tbIncome.Text = state[i].Income.ToString();
                            tbPercentage.Text = state[i].Percentage.ToString();
                            tbPop.Text = state[i].Population.ToString();
                            break;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Please select a  state!");
                }
            }
            catch (Exception bad)
            {
                MessageBox.Show("Something is wrong!" + bad);
            }
        }

        private void buttClear_Click(object sender, EventArgs e)
        {
            //this clears the form

            ClearStuff();
            cbState.SelectedItem = null;
        }
        public void ClearStuff()
        {
            //clears everything method
            tbFlag.Clear();
            lstbCities.Items.Clear();
            tbBird.Clear();
            tbCapitol.Clear();
            tbColor.Clear();
            tbFlower.Clear();
            tbIncome.Clear();
            tbPercentage.Clear();
            tbPop.Clear();
        }
    }
}
