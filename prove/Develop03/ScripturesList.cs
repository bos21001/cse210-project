using System.Collections.Specialized;

namespace Develop03;

public class ScripturesList
{
    private Dictionary<string, string> _scriptures = new Dictionary<string, string>();
    private Dictionary<string, string> _randomScripture = new Dictionary<string, string>();
    
    public ScripturesList()
{
    // Old Testament
    _scriptures.Add("Genesis 1:26-27", "And God said, Let us make man in our image, after our likeness: and let them have dominion over the fish of the sea, and over the fowl of the air, and over the cattle, and over all the earth, and over every creeping thing that creepeth upon the earth. So God created man in his own image, in the image of God created he him; male and female created he them.");
    _scriptures.Add("Genesis 2:24", "Therefore shall a man leave his father and his mother, and shall cleave unto his wife: and they shall be one flesh.");
    _scriptures.Add("Genesis 39:9", "How then can I do this great wickedness, and sin against God?");
    _scriptures.Add("Exodus 19:5-6", "Now therefore, if ye will obey my voice indeed, and keep my covenant, then ye shall be a peculiar treasure unto me above all people: for all the earth is mine: And ye shall be unto me a kingdom of priests, and an holy nation. These are the words which thou shalt speak unto the children of Israel.");
    _scriptures.Add("Exodus 20:3-17", "Thou shalt have no other gods before me. Thou shalt not make unto thee any graven image... Thou shalt not take the name of the Lord thy God in vain... Remember the sabbath day, to keep it holy. Honor thy father and thy mother... Thou shalt not kill. Thou shalt not commit adultery. Thou shalt not steal. Thou shalt not bear false witness against thy neighbor. Thou shalt not covet thy neighbor's house.");
    _scriptures.Add("Joshua 24:15", "And if it seem evil unto you to serve the Lord, choose you this day whom ye will serve; whether the gods which your fathers served that were on the other side of the flood, or the gods of the Amorites, in whose land ye dwell: but as for me and my house, we will serve the Lord.");
    _scriptures.Add("1 Samuel 16:7", "For the Lord seeth not as man seeth; for man looketh on the outward appearance, but the Lord looketh on the heart.");
    _scriptures.Add("Psalm 24:3-4", "Who shall ascend into the hill of the Lord? Or who shall stand in his holy place? He that hath clean hands, and a pure heart; who hath not lifted up his soul unto vanity, nor sworn deceitfully.");
    _scriptures.Add("Psalm 119:105", "Thy word is a lamp unto my feet, and a light unto my path.");
    _scriptures.Add("Psalm 127:3", "Lo, children are an heritage of the Lord: and the fruit of the womb is his reward.");
    _scriptures.Add("Proverbs 3:5-6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
    _scriptures.Add("Isaiah 1:18", "Come now, and let us reason together, saith the Lord: though your sins be as scarlet, they shall be as white as snow; though they be red like crimson, they shall be as wool.");
    _scriptures.Add("Isaiah 5:20", "Woe unto them that call evil good, and good evil; that put darkness for light, and light for darkness; that put bitter for sweet, and sweet for bitter!");
    _scriptures.Add("Isaiah 29:13-14", "Wherefore the Lord said, Forasmuch as this people draw near me with their mouth, and with their lips do honour me, but have removed their heart far from me, and their fear toward me is taught by the precept of men; therefore, behold, I will proceed to do a marvellous work among this people...");

    // New Testament
    _scriptures.Add("Matthew 5:14-16", "Ye are the light of the world. A city that is set on a hill cannot be hid. Neither do men light a candle, and put it under a bushel, but on a candlestick, and it giveth light unto all that are in the house. Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven.");
    _scriptures.Add("Matthew 11:28-30", "Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light.");
    _scriptures.Add("Matthew 16:15-19", "He saith unto them, But whom say ye that I am? And Simon Peter answered and said, Thou art the Christ, the Son of the living God. And Jesus answered and said unto him, Blessed art thou, Simon Barjona: for flesh and blood hath not revealed it unto thee, but my Father which is in heaven. And I say also unto thee, That thou art Peter, and upon this rock I will build my church; and the gates of hell shall not prevail against it.");
    _scriptures.Add("Matthew 22:36-39", "Master, which is the great commandment in the law? Jesus said unto him, Thou shalt love the Lord thy God with all thy heart, and with all thy soul, and with all thy mind. This is the first and great commandment. And the second is like unto it, Thou shalt love thy neighbour as thyself.");
    _scriptures.Add("Matthew 28:19-20", "Go ye therefore, and teach all nations, baptizing them in the name of the Father, and of the Son, and of the Holy Ghost: Teaching them to observe all things whatsoever I have commanded you: and, lo, I am with you alway, even unto the end of the world. Amen.");
    _scriptures.Add("Luke 24:36-39", "And as they thus spake, Jesus himself stood in the midst of them, and saith unto them, Peace be unto you. But they were terrified and affrighted, and supposed that they had seen a spirit. And he said unto them, Why are ye troubled? and why do thoughts arise in your hearts? Behold my hands and my feet, that it is I myself: handle me, and see; for a spirit hath not flesh and bones, as ye see me have.");
    _scriptures.Add("John 3:5", "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.");
    _scriptures.Add("John 14:6", "Jesus saith unto him, I am the way, the truth, and the life: no man cometh unto the Father, but by me.");
    _scriptures.Add("John 14:15", "If ye love me, keep my commandments.");
    _scriptures.Add("John 17:3", "And this is life eternal, that they might know thee the only true God, and Jesus Christ, whom thou hast sent.");
    _scriptures.Add("Acts 2:36-38", "Therefore let all the house of Israel know assuredly, that God hath made that same Jesus, whom ye have crucified, both Lord and Christ. Now when they heard this, they were pricked in their heart, and said unto Peter and to the rest of the apostles, Men and brethren, what shall we do? Then Peter said unto them, Repent, and be baptized every one of you in the name of Jesus Christ for the remission of sins, and ye shall receive the gift of the Holy Ghost.");
    _scriptures.Add("Acts 3:19-21", "Repent ye therefore, and be converted, that your sins may be blotted out, when the times of refreshing shall come from the presence of the Lord; And he shall send Jesus Christ, which before was preached unto you: Whom the heaven must receive until the times of restitution of all things, which God hath spoken by the mouth of all his holy prophets since the world began.");
    _scriptures.Add("1 Corinthians 6:19-20", "What? know ye not that your body is the temple of the Holy Ghost which is in you, which ye have of God, and ye are not your own? For ye are bought with a price: therefore glorify God in your body, and in your spirit, which are God's.");
    _scriptures.Add("1 Corinthians 15:20-22", "But now is Christ risen from the dead, and become the firstfruits of them that slept. For since by man came death, by man came also the resurrection of the dead. For as in Adam all die, even so in Christ shall all be made alive.");
    _scriptures.Add("2 Corinthians 5:7", "For we walk by faith, not by sight.");
    _scriptures.Add("Galatians 5:22-23", "But the fruit of the Spirit is love, joy, peace, longsuffering, gentleness, goodness, faith, Meekness, temperance: against such there is no law.");
    _scriptures.Add("Ephesians 2:8-9", "For by grace are ye saved through faith; and that not of yourselves: it is the gift of God: Not of works, lest any man should boast.");
    _scriptures.Add("Philippians 4:13", "I can do all things through Christ which strengtheneth me.");
    _scriptures.Add("James 1:5", "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.");
    _scriptures.Add("Revelation 12:11", "And they overcame him by the blood of the Lamb, and by the word of their testimony; and they loved not their lives unto the death.");

    // Book of Mormon
    _scriptures.Add("1 Nephi 3:7", "I will go and do the things which the Lord hath commanded: for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
    _scriptures.Add("1 Nephi 10:19", "And thus God is not a partial God, but he is a God of justice and a God of mercy.");
    _scriptures.Add("1 Nephi 15:24", "And thus the devil hath power over the hearts of the children of men.");
    _scriptures.Add("2 Nephi 2:27", "Men are, that they might have joy.");
    _scriptures.Add("2 Nephi 9:28-29", "O that cunning plan of the evil one! O the vainness, and the frailties, and the foolishness of men! When they are learned they think they are wise, and they hearken not unto the counsel of God, for they set it aside, supposing they can lift themselves up by their own bootstraps.");
    _scriptures.Add("2 Nephi 25:26", "And we talk of Christ, we rejoice in Christ, we preach of Christ, we prophesy of Christ, and we write according to our prophecies, that our children may know to what source they may look for a remission of their sins.");
    _scriptures.Add("Jacob 2:18", "But before ye seek for riches, seek ye for the kingdom of God.");
    _scriptures.Add("Mosiah 2:17", "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.");
    _scriptures.Add("Mosiah 3:19", "For behold, the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord.");
    _scriptures.Add("Alma 37:6", "By small and simple things are great things brought to pass.");
    _scriptures.Add("Alma 41:10", "Wickedness never was happiness.");
    _scriptures.Add("Helaman 5:12", "Remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation.");
    _scriptures.Add("3 Nephi 12:48", "Therefore I would that ye should be perfect even as I, or your Father who is in heaven is perfect.");
    _scriptures.Add("Ether 12:27", "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble...");
    _scriptures.Add("Moroni 10:32", "Yea, and whosoever shall come unto me, I will show unto them their weakness. I give unto men weakness that they may be humble.");
    _scriptures.Add("Moroni 10:33", "And now, I would commend you to seek this Jesus of whom the prophets and apostles have written, that the grace of God the Father, and also the Lord Jesus Christ, and the Holy Ghost, which beareth record of them, may be and abide in you forever. Amen.");

    // Doctrine and Covenants
    _scriptures.Add("D&C 1:37-38", "What I the Lord have spoken, I have spoken; and I excuse not myself; and though the heaven and the earth pass away, my word shall not pass away, but shall all be fulfilled, whether by mine own voice or by the voice of my servants, it is the same.");
    _scriptures.Add("D&C 4:7", "Ask of God, and he will answer.");
    _scriptures.Add("D&C 6:36", "Look unto me in every thought; doubt not, fear not.");
    _scriptures.Add("D&C 11:21", "Seek not to declare my word, but first seek to obtain my word, and then shall your tongue be loosed; then, if you desire, you shall have my word delivered unto you.");
    _scriptures.Add("D&C 12:8", "And no one can assist in this work except he shall be humble and full of love, and faith and the Holy Ghost.");
    _scriptures.Add("D&C 13:1", "Upon you, my fellow servants, in the name of Messiah, I confer the Priesthood of Aaron, which holds the keys of the ministering of angels and the preparatory gospel.");
    _scriptures.Add("D&C 42:11", "Thou shalt not steal; neither deal falsely, neither lie one to another.");
    _scriptures.Add("D&C 49:15", "And again, I say unto you, that whosoever among you shall give heed unto these things, and receive them in faith, shall be made strong, and shall bring forth good works.");
    _scriptures.Add("D&C 58:27", "For verily, I say unto you, that it is my will that men should be anxiously engaged in a good cause, and do many things of their own free will, and bring to pass much righteousness.");
    _scriptures.Add("D&C 76:22-24", "And now, this is the will of the Lord: All who have been called, who have been chosen, who have been sanctified, who have been sealed with the Holy Spirit of promise, will come forth in the resurrection of the just.");
    _scriptures.Add("D&C 88:40", "For intelligence cleaveth unto intelligence; wisdom receiveth wisdom; truth embraceth truth; virtue loveth virtue; light cleaveth unto light; and mercy hath compassion on mercy, and claimeth her own; and a man is rewarded according to his own works, according to the law which he has transgressed.");
    _scriptures.Add("D&C 93:36", "The glory of God is intelligence, or, in other words, light and truth.");
    _scriptures.Add("D&C 132:19", "And if a man marry a wife and make a covenant with her for time and for all eternity, and it be sealed unto him by the Holy Spirit of promise, by the power vested in me, and the witness of my Father, he shall inherit thrones, kingdoms, principalities, and powers, dominions, all heights and depths.");
    
    // Pearl of Great Price
    _scriptures.Add("Moses 1:39", "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.");
    _scriptures.Add("Moses 7:18", "And the Lord called his people Zion, because they were of one heart and one mind, and dwelt in righteousness; and there was no poor among them.");
    _scriptures.Add("Abraham 3:22-23", "Now the Lord had shown unto me, Abraham, the intelligences that were organized before the world was; and among all these there were many of the noble and great ones.");
    _scriptures.Add("Joseph Smith—History 1:17", "And when the Lord first revealed Himself to me, I had been very much troubled with a conviction of sin, and had gone forth to make a prayer unto the Lord.");
}


    public void DisplayScriptures()
    {
        _scriptures.ToList().ForEach(scripture => Console.WriteLine($"{scripture.Key}: {scripture.Value}"));
    }

    public void SelectRandomScripture()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _scriptures.Count);
        _randomScripture = _scriptures.Skip(randomIndex).Take(1).ToDictionary(x => x.Key, x => x.Value);
    }
    
    public List<string> ReturnReferenceList()
    {
        // separate the book, chapter, and verse
        string[] reference = _randomScripture.Keys.First().Split(' ');
        // Get the last element of the array
        string chapterVerse = reference.Last();
        // remove the last element of the array
        reference = reference.Take(reference.Count() - 1).ToArray();
        // join the array back into a string
        string book = string.Join(" ", reference);
        // separate the chapter and verse
        string[] chapterVerseArray = chapterVerse.Split(':');
        string chapter = chapterVerseArray[0];
        string verse = chapterVerseArray[1];
        
        return new List<string> { book, chapter, verse };
    }
    
    public string ReturnScriptureText()
    {
        return _randomScripture.Values.First();
    }
}