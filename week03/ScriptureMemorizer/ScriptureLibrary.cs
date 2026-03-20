public class ScriptureLibrary
{
    private List<Scripture> _scriptures;

    //contructor lo load the scripture
    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();
        LoadScriptures();
    }
    //method to load them into the list
    private void LoadScriptures()
    {
        _scriptures.Add(new Scripture(new Reference("John", 3, 16),
        "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life"));
        
        _scriptures.Add(new Scripture(new Reference("Moses", 1, 39),
            "This is my work and my glory—to bring to pass the immortality and eternal life of man"));

        _scriptures.Add(new Scripture(new Reference("Mosiah", 3, 19),
            "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father"));

        _scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all your heart and lean not on your own understanding"));

        _scriptures.Add(new Scripture(new Reference("Alma", 39, 9),
            "Now my son, I would that ye should repent and forsake your sins, and go no more after the lusts of your eyes, but cross yourself in all these things; for except ye do this ye can in nowise inherit the kingdom of God. Oh, remember, and take it upon you, and cross yourself in these things"));

        _scriptures.Add(new Scripture(new Reference("Philippians", 4, 13),
            "I can do all things through Christ which strengtheneth me"));

        _scriptures.Add(new Scripture(new Reference("Moroni", 7, 45, 48),
            "And charity suffereth long, and is kind, and envieth not, and is not puffed up, seeketh not her own, is not easily provoked, thinketh no evil, and rejoiceth not in iniquity but rejoiceth in the truth, beareth all things, believeth all things, hopeth all things, endureth all things. Wherefore, my beloved brethren, if ye have not charity, ye are nothing, for charity never faileth. Wherefore, cleave unto charity, which is the greatest of all, for all things must fail— But charity is the pure love of Christ, and it endureth forever; and whoso is found possessed of it at the last day, it shall be well with him. Wherefore, my beloved brethren, pray unto the Father with all the energy of heart, that ye may be filled with this love, which he hath bestowed upon all who are true followers of his Son, Jesus Christ; that ye may become the sons of God; that when he shall appear we shall be like him, for we shall see him as he is; that we may have this hope; that we may be purified even as he is pure."));

        _scriptures.Add(new Scripture(new Reference("Psalms", 23, 1),
            "The Lord is my shepherd I shall not want"));
        
        _scriptures.Add(new Scripture(new Reference("Doctrine and Covenants", 1, 30),
            " And also those to whom these commandments were given, might have power to lay the foundation of this church, and to bring it forth out of obscurity and out of darkness, the only true and living church upon the face of the whole earth, with which I, the Lord, am well pleased, speaking unto the church collectively and not individually—"));
    
    }
    //method to get a random scripture
    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(_scriptures.Count);
        return _scriptures[index];
    }

}