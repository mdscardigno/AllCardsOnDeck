# AllCardsOnDeck

PEDAC

PROBLEM:
Create a deck of cards
Shuffle deck of cards
Use Shuffle Yates Algorithm to shuffle the deck of cards
Display the two top cards as a string: "Ace of Spades"...
52 cards made of suits and ranks
4 suits and 13 ranks
4x13 = 54

EXAMPLE DATA:
Ace of Clubs
1 of Clubs
2 of Clubs
3 of Clubs
4 of Clubs
5 of Clubs
6 of Clubs
7 of Clubs
8 of Clubs
9 of Clubs
10 of Clubs
Jack of Clubs
Queen of Clubs
King of Clubs

Ace of Hearts
1 of Hearts
2 of Hearts
3 of Hearts
4 of Hearts
5 of Hearts
6 of Hearts
7 of Hearts
8 of Hearts
9 of Hearts
10 of Hearts
Jack of Hearts
Queen of Hearts
King of Hearts

Ace of Spades
1 of Spades
2 of Spades
3 of Spades
4 of Spades
5 of Spades
6 of Spades
7 of Spades
8 of Spades
9 of Spades
10 of Spades
Jack of Spades
Queen of Spades
King of Spades

Ace of Diamonds
1 of Diamonds
2 of Diamonds
3 of Diamonds
4 of Diamonds
5 of Diamonds
6 of Diamonds
7 of Diamonds
8 of Diamonds
9 of Diamonds
10 of Diamonds
Jack of Diamonds
Queen of Diamonds
King of Diamonds

DATA STRUCTURE:
string
List
Loops
Interpolation
There are four suits: "Clubs", "Diamonds", "Hearts", and "Spades".
There are 13 ranks: "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", and "King".

CARD GAME WAR
GAME STARTS WITH TWO PLAYERS (PLAYER HUMAN AND PLAYER CPU)
HOW MANY ROUNDS?
A DECK OF CARDS IS SPLIT IN HALF
HALF OF DECK IS GIVEN TO EACH
EACH PLAYER REVEALS A CARD FROM THE TOP OF THEIR STACK
OBJECTS WE WILL NEED
PLAYER THAT RUNS OUT OF CARDS FIRST WINS

Algorithm A
-Make a new list of strings named `deck`
-Initialize the list of string with 52 explicit stated cards from our Example section.
-Shuffle them with Fisher Yates (paste algo here)

numberOfCards = length of our deck

for rightIndex from numberOfCards - 1 down to 1 do:
leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. See the section "How do we get a random integer")

Now swap the values at rightIndex and leftIndex by doing this:
leftCard = the value from deck[leftIndex]
rightCard = the value from deck[rightIndex]
deck[rightIndex] = leftCard
deck[leftIndex] = rightCard

Algorithm B

-Make a list of the 4 suits
-Make a list of the 13 ranks
-Make a new list of strings named 'Deck'
-Make a loop that goes through the list 'suits'
-For Clubs:
Make a loop that goes through all the ranks and call this list 'ranks'
for each rank, make a new string of the form $"{Rank of Suit}" //nested loop
add that newly formed string to the end of the deck list (so we constructed a deck of cards)
Same as Algo A

CODE
