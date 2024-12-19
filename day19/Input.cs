﻿namespace day19;

public static class Input
{
    public const string ExampleInput = @"
r, wr, b, g, bwu, rb, gb, br

brwrr
bggr
gbbr
rrbgbr
ubwu
bwurrg
brgr
bbrgwb
";

    public const string RawInput = @"
urbu, wrrbwrg, rgug, uwb, uwg, wubwgu, bgrwu, gubbuu, wrrub, rbr, bgrr, rrgrrur, rgu, ugrrru, bgu, uubbwrb, ugru, bwb, uwuu, urb, gwubw, ubu, wubwu, ubb, rugrgw, guu, rbwg, rug, brgugb, rwbrbwu, wu, bgrb, wgburg, uuguw, wbggr, guurrbbu, rggw, guwr, rwgrbrb, urbb, bwggwg, wgr, bbwurrw, bgubr, uuu, grru, rbbrbgbr, buwub, urr, gwrgb, wrwrgubu, rurrb, bwbuub, bgbub, wguu, gbrburw, rrb, rwuu, wgwgwubb, rruw, rurru, uuw, uu, ruu, wrwb, wbrgu, gwbuu, bbgw, grgggbr, bwgww, wbuw, wwb, wubguurw, wbuu, uwurgw, ugwbbbr, rbg, uburg, wrbug, gu, bwuugb, rbuwrbur, wguur, wwwbgu, ugbb, guwubw, uwbug, rwub, uwwgug, uur, wrg, ubgbb, uw, wru, uww, uubwg, wgrgw, bu, ugb, rur, bbw, wbgru, ruug, rrbb, ugu, urbgb, bbgu, bgbwgg, gbrwb, brub, wbu, rwbuur, bgggrw, rg, bgwr, wgwwuwu, gbg, gw, ruuw, wr, bww, uwr, ubgg, guwrw, rrr, wburguu, wrbbrru, rwwrg, rwg, bgg, wgw, www, gggbrrur, gbw, rgrr, bb, bwrwww, rb, rgbbu, bubu, ubwubw, w, wgbb, gwwb, r, gru, wugr, b, bubwu, ub, uugggg, ruwuub, buw, uuruuub, gb, grbgr, wwrg, wwg, grwr, wwr, rbrb, wwrrub, uuwbwgw, gggr, rgubr, guggu, rgwwg, bggr, wrruu, grub, gbbbbr, ubw, rbubw, bbbwwww, wuu, uwuuwww, wwu, gww, wbw, rwb, gbwg, bwr, gubgu, urubwrub, uuuw, rrw, wwruu, ggg, bwrrg, bugw, urw, gggwgw, uwgrgwrr, ugr, rgru, bgr, wbbwb, brg, rwbw, bwuu, brw, bbwbuwu, grur, wgbbwu, ru, rwu, rrgb, urbwrub, ubug, bwu, wbgbbg, uuubu, wbrgwrwg, gbgg, buu, uugu, rrbuu, brbg, brwuw, rbbbw, rbgr, buggrug, gbwr, gwr, wrrw, urug, bbbb, bbrgu, rrbwuru, ugggw, bbb, rrbrw, ubg, bwubgw, ugw, urwgr, uwwrgw, ugrbwu, rggwwwb, grubb, brb, rww, ububwr, brruburb, bbrgrur, uwwbgg, gbbrr, rggu, bbwug, wrb, wgugu, br, bbu, gbr, wbg, gbuw, wwug, bru, grwrur, bbr, bugwur, wrug, rrwbu, rw, uug, rgr, ugrubu, rbb, brgwug, rgwbg, rub, gbbg, bur, grg, bubgg, ugg, rbwu, rwr, bub, rrguw, gubb, bbgr, wbbburg, bgw, wb, wubw, ggwuub, bwg, bwbbrw, ggw, grubrg, rgw, uwwuw, uwbr, grr, rgb, bwrggwg, brbwur, uru, bguuubr, wwuwg, wuruwwbw, grrwwrgr, bwbu, rbuuuw, ubru, uub, uwbb, ruw, gwg, rbur, grw, gbgbu, uwbugw, wbb, gurb, ugbwgub, rgubrw, bbugu, urg, wrr, bw, wbubruw, wwwr, rrrb, ggbbbg, wug, rgruu, guwb, uuuggug, brrbrr, gr, buwbguwu, rgg, rrwg, wwgwrr, rrg, wurur, ggwbbrg, rrwgr, rruwu, buww, gbu, rrwuruub, brgr, wguwuu, urbrbg, rru, wgb, urubb, rbw, guru, buru, gur, ww, u, rwgw, gug, wwurwuw, rrbgrw, bwuwubu, bgrw, gguuugub, rbu, rubub, wrw, ggb, buwugrg, wgu, wwrbuu, bgurbg, gwu, bbwgb, uwwrrb, urugu, wugwrrgr, gwbbr, rgubg, bwrww, ug, wrwr, brur, bwur, gwgguw, wuwub, burww, gubwru, gub, bug, bwww, gwgugg, gruw, wgg, wrub, uwuwbgu, bwbw, gwuw, ubr, gbb, ubggru, wwubuw, rgrgru, wg, wub, wrgww, bwwub, gbur, bwgu, ur, rgwrrbw, wguuurb, rwrrg, ubrbburg, rgbggww, rgbgrur, brr, wrggbwr, ggr, guw, bgwb, gwrbwg, wrwbug, ubggu, bgrrb, wbr, wgub, gwbw, grb, rwbubwur, ubgw, gwbb, ugwwggrb, ggww, wugwur, rubwg, bgugw, wbubbu, rbbw, bgug, uggu, bgwrwrw, gwb, bgb, uwug, gurguug, wrrbw, gg

wbrurgggrgbuwguwuwuwuwwwwgugwbwrwwuguwrrwubwuwrgwbugw
uubrgurbrbgwgbbrruwrwrwgbrrgguuwrwbrgwgwgrgrgu
bugwgurruguwwbgwuuggrrbrubgggbgrubbwuuuuuurrgwwurwguwugggg
brwugubrrbrgubrwubgwbrggrrrbwburgbugrwbrwubbg
gbggwbrwugrbbrrbbrgbbbuguwwurrgguwrbubbbgbbgbbbg
bgrwgugurwugurrwwgwbrruubuwuwggrubwrbbugggw
wbrwrugwbugrubgwuggguwubbbrbrgrugwugggggrbbugwbgbbrbbg
rwrbbrubwrbbbwurggwgurrwubgrwwwurwgburbbwgwu
rubbbgggwuwggubuwgrrwurwgwbrwrguurugbgrgbbuburgbg
bggubbgrgruubbbubrbburggguwgggrrguuwuubrugbgbgwuruur
ugwgugugubrbgwwwguugrwbwubburwwgwbrbrbbbwgbb
gbgbbrbrwububuubgbwubgbbwrrwwggbugwrwbgrgwwggbwgggbrbuwwg
ugubgrbwbubrbugwguwrurguwwrgbrrurrbubuwrgburbwwgwu
gubbbrwguugwwgbwbwwgbbgbuubbgrburrururgwbwr
gwwbrrbwguurgrbgrwbubggurbbugrbwggrrwbgggbgbugbur
wruwwurwuwgugurugwbuwbguwuwgugwguwuugggwubbrbu
grwbuwuwrgubwbubuwwbbwrwbwrggbgugbbugwuuugg
burguuguuuuguwwggruwgbggbbbuuubwwguuwbgrrrrbuuu
urbbgrwgbbbggurggbwuwgrubrwbgrbwugbwubwugbwrurw
gggrbbgurruuguwwbbwguuugrwggbubwrubgbwwwgwbrgwwugrwgb
rrrgrurwbwgrggrbrubbbbrgruubuuwgrgwrruwrbgb
rgwrguggbgbwwbwwrggurgrgbuwubugwrugwbuggurbgwgwwrwgw
wuwbuugggbrggbwgrugubrgwwrurwuuggubwwubuwwwwbubrrbwwbwubbg
wuuuwgguuwgwgbrrbubbugggwbwgrwwgrgwubrgwbrwubwwwww
ubugbugrwbwwgbgugbruububggbgwwgggbggwuwuurruugbugrgrb
wguruubgbbrgubguuwgbugurrbbwubruguwuggbwrguuguwrwuuwbbg
rurwgbwbbrwrbugwwwbbuwwbbrrrbuuuugwrburgwbbbbwg
wgbbgbwrwrrgubrwbgwwguwuwwugrbwwrubgrwburgrrbuwrgwrbrugbuw
uggbrggbgwwgrbbrurwuuwgguwrbrgggwbrrggwuruurwrubgugguu
gwbgrgruuubgwbrrrwwurgbbugbgbwgwgwubbwwurwrrurbubg
wurrwuugbuggbrrrgwwugurgguurgugbbrgurgbwrwrbbg
uwrggrgbrwbgrbgbbuwrubbububgwbrgbgubwbguuuwbr
bbwurbgwuuwurwrwbrgrwrrbuubuggrrbwwgbwwurrrbugwwbubgubwr
rgbrggrurgwbwbuubgurruwrgubuuwrwrrwuwrgbwugrbbguu
wuwrgrbrugrgwugubggbubbrbbrgbbbrbbwgwbbg
ugwwbubwbruubwwgrwrburwrurubbwwrrugrbugugguwbuwwwgb
rgwuuggbrwbgubbbbuwwuuruurbugbbugbbrrgbwbwgurrggu
gugwwruurgwrrrwugbuwguubuwbwrrbugbggwwuwruww
ruugbggrubrbburgrbwwgugbgwbrguugrgggwrwwrggggubwuuugguwuubbg
buubbwgbggbrubgurgurrubbbrgwuruurbwgbwuubwb
rbwguwubgrwruggwrwuubuggwurburbwbggubbwguuw
bwuuwrrrwbburggubwggbuguwuwwwruwuwggwuuwubrrbu
rrwwwubrrwrgburbrwbbbgwbgbwgugbrwwrrbbgubgguuuwguuurrg
guurrbburuugggbwwwgbgbgugwubbgwbrbugbbbg
rbbrruurbrgbrwrwruggwrgguuwuwwgrbgwwrbgrbbrbgbrrgggwwbgwwu
wbbgbrrbrrgwbuwwwuwwuwruwbgwrrgbwuruuggbgbbbg
rwbbrgurbwbwwbburwwguwgrrguuwgggwbgrrurbwubrruwgb
rgrburrrgurwrgrbwurwwggwuuubwrugrguubuwugwwbbg
urgwbwurugbwbgbbrwguggbugbbuwgguwgugrrwwgrrggrgugbrgbruwbbbg
urwbrgggbururbwwrubgugwrgwbwbbwwbwrgrwgwrrggrbrurgggww
rwguwwgwrbugrwruurbbbbwubwwbrwgwuwwrubwwbuubbwuuwuuwwbrg
grubugbuurgwbgwwgwbbuugurugwbbbwubgurrurgwubbg
grggguwubgbrwrrbgwuuwbgwrbgbuwwrrubbbwugrbubg
bbbbwwurbrbbruubwuurwwwuuwbrbbbrgbwugrrgbbguwrubuuwbbg
urruwrbrruburbugbwgruguuuuwbubuwrwgrbgrgrb
urgrwwrggbgrwuubgbgwrwrurwubguruguwugubugwbbbrgg
ggbuwugrugbgguwurgrgwgbgwggubbrwrurrwuwwuurbbrgwwrwww
urwgbugrbguuuwuwwbggbwruubgbbubgrgrwruubrwrugbbbbgwbg
grbwgwgwuwwrugwuuggwrrurrrbwubbgrrgguwburuuuwrubg
uubugggrgurwrrbgrgubrwbubwgwgrrwwrgruurrbbbgbwgwubbg
rgwrbgrbruuubburgrgguuwgurguuggbruurbbugwwrwbubbrbbg
bgwubwuuwwubgwrrwggrubrrbgbrbgubrrbwugbguubwbwuuuwrbgrw
rbwgwwugburbgbgruguguggrgrbbrgrbrrwugbuubuurwurrwrbrrbbbg
grbguwgrrrgbwugwrrgrgbbbrwrrrugugrgrrbrwrbrbrrwuubuuw
bbbwugwbwrwuwrurwuuuwgbguuwurguwrgruwggurrwbgubgggbwb
wgrbuwrburrgwbuurbrbrgbbuguubrrwugwbgwggwggrb
gguwbbbubgrwrurrgbuburwwwrgbwwgbrwgbuwwrwbgrguugbgbgwrr
rbgwbubgbwwbuubwrwbgrgbwrrgrwgwguwburbbbbbugwgbu
wrruwrguwrwuwbrbgwguuurrugbwggrruugrbgugbbwurbruurgurbbg
gugubbuubrguuuugbuwubwbwgubwwwwgwgwuwgrrwubu
uruuuuggwuuwgwgwbrwwgguwgbuuwwrguwguwuwrwgwubbrrw
buuwrrgrwbrugrrwwbbguurbwwbgugbbguwrwuubrwuggw
rrurgugbrbrbwbbubbggwwuwwwbrurbwugwbbgwwgg
wgwuwguurbggrbwgrrrrggbuwggrwgbbgwubrgbrburbgwwurwu
uwbwgwwbwurrurruugbggurbrgwwgrbuwurggwubuwr
uuwwrwwwuuwwguwubgubbrurbbrgurwwgrrubbgubb
rgwgguguguwwuwbbrgbuwguwggbrwgbugrwbugwbubgb
gbbrwbwrrwgbwgwurugwuwbwbwwwrrrguuubggwrurwbwrbbrrwwrgwgb
wuguwwwgbrbwubuuuguburugbbwgwgubwbugbgrrugwwwgbgbubgrw
uugbwguubuubbrbrguwuwwgurbbwbgrgbugwgwgggrubbg
wbrwurwwruwgwuuwruwgbrwrgrrbrwwgurbugbrgbbbbg
ruuwggwgwrrwgbrbwuuwuuburrgbbrguwugbrrubrwuu
ruruubgrrugggruruubbubugruruwbruwwgugwbgwuwuuwwbubbwbgwu
bgwubguurgwuggwgwrrwgwuubrbgwbrwuurwwbrrurwgrgwgwrrrrwwru
rrgbbgwwwbbwuuuruubgurwugbrrgwruwrurwbbwrg
gwgbwwurwrugrrruwbbuwbugrbubgbggwuubwrurwugrwrugurbwgubbrb
uwbgbggbwwuwwrwgwrrrbwbwwrbubwgwbbrrwguwgbuwuubwrburuwbw
rwgbguruuuruwbgbwrbrgggrbrgburwbrugguwrrbbbg
bugubbrubrbgwbbruuurbwgwgbbgbrbruugrbrbgrgrbbg
guugrwwrwrgubuwbgbwrrgrbggrrgrubgruugbwrbrbwu
wbuwubrggubgrggbubrugbrwwgwurrbgwgwwbuwgbbwurbuuububbggb
ugrugrubbwruburbbgwrburbbrbgbrbrggwwwuuuwwgurruubbrbbg
grbbrrubbbuwwurrurwwugggubrgbbwguwgbbgwbwwrr
gbwbbwbugbggbwrgrwbbbbuwruuruuwrwbrrrgwuwubbugrgwwrruguwub
ruwgggwgwgubwwgrubgrwrguurrrubwbgbgruburwrgugruwuubwgwrbbg
bwrgugwuubuwgugwgrgrugrgurwgwrgbuwbbrrbgrbwwrgbbugubbugbbbg
rbrgrbuurgbwrrurwbrbrrgwgubwbbwuugrbwgbrgbrrw
gwuuubuuggrwrbwruwbrwgwwruurbugwrgwwurrbrwwbbgwbbubrurbg
ggrrwgrrgburwrgurbbwwwrgrubrugrrwgbwbbbgbbwuuurubbgb
rbugrwrubwuurwrrwwbwwwggwurwgrrrrruwggrgrurr
ubgwrbbbrrbwwgwwbbwbwwurruwgbbubwugurbuubbwuubrburbbg
ruuubrurgrgubuggrwgrbrbwbuuguwuburwuwuuggwgugrugbrgwurbww
gwbrbrbrwubwbuururubrgubgrrgburrrbrbbrgugrwgwgwurb
gguurgwgugrbwgbbbrwwbwgwwggubwbrrubrwbwrrbbg
wugwrrgrwgguuurwwbgwururrwurwwbrrwgrwbbg
brrrwwwuwrbubbgrruwrwggbgwrgurgbrrwbwwwbwugwgr
bgwrruwbrbubugwggrbbrggrrwwguububwbuwrgwbrgrrubbbbbgrgwuww
rwbwbrbrguuwurwwrwgwururgwuwgbruburwbbwrbrwgbrwubwgwrgrrrw
ugubrbugbwggwbwuggugrwbggbbbwrubbrwugugwwburugbwbbg
ruwbbwrbwwuububwwuwurbrrwrbggbbrrbrwrwwgwbgbrgbwb
gggbbwgwuuwrbuwwrburggbugurwbgbbgbruuwbbg
gbrbgggbruurbgrwrrrbgwwruwugbgrwgwwrrurruwruubrurbrubgrwg
bugwgbuwbbggrbuuggurrrrgrwwrrbbuwrrbugugwgwwuggrbgrggrur
rrwgurwwgrbuurbgguwurrugggbrwwugwwubrrbbgwwburbrwu
wwbgbwubwuwbbbburgugugubrbwgggbrbgrbbbggwubrgr
rbbuwrbrbbwbwguruwrggurgurwrgubbwrrwrwruwwuuubw
rbwbguuwwrgrwurbbuurgubuubuggrrwrggwrgwbgbuwrwu
bwgbwbbubguwuugwrbrgbrguwrubuwguuwggwwburw
rgruwruwrruwrurbrguuwrrbbbrrgwubbururgwgrur
burwugruurwwwwrwbwrrrbubgrrrrubuuuwwbbgrbg
bgbwrggwguurbbubwwwbuugwggubrgbubrwgwwwrwubbbg
uwuruugwbbwbuwgrwgbbrbbgggggwuwggbwuubgbrrguw
rbguuggrruwrrubggbuwrrwguwrubbbrbrrwgbgguuuuuuguuuug
rwbwgurrbgurwrgbbrugwugugrbrwuuwrbgrgbgguwbgbubuuwrbg
rrrrgwuwubwwuububwugruurbgburgbggburgbgwwuuuugwwrb
wwgwubbwbrrurgrubbrubgrwrgbwrrruugwbrubugrrrbgwbbg
uuguggrugguwgwrwbguwrgbrgugwwggrbwbubuwbwbwrrrwwuggruwwbwbbg
bbrugbguwrgrurwwgbwwwrwgwbbwugbwurrrwbubuggrrbwwwwgb
uugbbwburgbbruugwrubgugbwwugggggguugruuwbrbbg
uwuurugrwubgggrgrugggrguuuugbgwwurrbuwrugbr
wubrbgwgrwrwbwuggbwbgggrbuwwrbwggruugrggrrwubguurwbbg
gbugrwgruuwwubgwbwbuguugggrggwwbgbubwgrubgbgrubgugur
wwurwrurrrbugrbuwbwwuubrrbgwugbbuuwgrrbwwrbuwbbwwurbwrur
rgurbugurgrwrrwbrrgwrgubwrbwbugwubrbwgubuuggrugwuguw
buwrgrrgrwgggbwgubgrrbgggbugwuugrrwbgubwugwruuruguw
rwururuurggbugwrgrrugrbbuwwbwrwbrburgugwwrugbgwgwb
ggubrgbbrrgrgbuwuwurrgrrbbbwbrurrgbbbbgubrg
wwwwgwrgubgrgubbrrwbbubbugurrwugbrgurrbggugbbbwgb
rbrrrubuggrbrubwwuwbrwurgrwbwbgbbwrrbrrwgrbrggwbbugwbwwr
rwugrbrbwwbugrbbuuugwurrgrrbuuwbgrrbrrgrrgwguwgrbbuuugugbbbg
rgwrgrbububuubgbrrgwurwwrbrwwbbbbwgbgrbgwruwgwbgbrubrwgugw
uggwubwggbwuwrggrrububgbwbrbwgrrgbwbwggwubwr
bggugrbbuuurwuurubwgwwrburggwuubwuguwrgrrgrburgr
rbrwwrrgrugwuwrugwwbburbuwwugrwgurwbwruuuurgwrubuubbbbbg
gurgwbbubrrurwbubgrguwgbgwuuugggrgrggubugubwbbg
uuubrbgwbrbbrgugrgbwubbrurgrugubbubwbrrwurgr
bwbbrurgbbrwrbubgwgubugubuwbgruwuwgruwwwuuruu
rwbgwuruubugggbrrurrrubwbwwwgrrwugbrgwgwbwgrggbrrr
bwwwwgruwbuwrwbrrbbuburwwbggrgbwururrwggubwrugwwgbbugw
ubguggwugubgggbguuwgruuubgrrbgwwuurruwruuwrwbbwubbbbgbw
uburwubgwugbgugwrwrbbwbrgbuwuuwrrwbrgbgrgbwwgwrbgbwwrbgwb
rugurrbbgbrurrggbrbbgrugubwrubwgbuwuwbrrwgrrubbwbrgb
gubwubbuwrbrgrrgwuwbwgggguggrgwgwugbrwruuwurgwrrbbg
wggrwbgggrwrggrgrwrbbuurguggwrrubuuwggwbgbgbbggbr
rwwwurwbbrbrubrruwuuuurrwwrurgrrbbwuruwbru
uwuuggbgbuwubrrggrrbgwgrrbubbrrurbwguguwgbrubbg
ruugbbwggbgwurwwbgbrrbwburuuruggbgbuuwbbguuw
rbrgbuugbwuggrruurrwbbbguguurururwwrwbrwrwuwwbbw
wwgrruwbrbrrrbgrbbrgrwrwwbwruuugrwbuwrwbbrgbrwr
wrwrguburwbuwbrgwurbwrgrwgbgburwgwgrrguugbbrugrbwgbgrrbbbg
guuruugubguwggrbubwgrgwbbbugrrbbguguwuubbbbbg
wwbrwurrubggrrbrbbuuwuwwbubgbwbgrbubrurugbrgbgbbbrubbr
wwwrburruwbwguwwuwruwugwguuugbwgwrrgbuggwburgwggrbw
grgwrruuuubuurbururguwwrrwgwwburwrrbwgrwrgguurrb
rwgurwuburbbwrwgrwrgurbwbrrwrbuwgwuurwuwguburwurburr
bubwgbrrwwrbgbrwwurwuurwbuwuruurbrwwugugggguubuububruw
gurbwgwuwuwgwwuwrrrrurbbugwgrgwrgugubgbbuug
wurbrggwgrbguubgrggrwwgwurubburggrbgrwwbggbwrggbwurguu
ugwgwwwrurgbbgrrgrgbbrwgwwbubwbbbrwbgrurbbbuwrw
wbrubrwbgbwrbbburbrbubgbggugrrrgubwrgbbbbg
rbbwbwwwbbwrwuuugwurgrubuuwrbguwggwubrwburgwrgurugwuwrw
wubbwbruuuburbguwwrugguurwbrrwbuwbgwwrwubuwgwwwggbuw
wrbwrrgugubwbbrwrgbruwrrruuwrwgurugwbrbburwrgbguurw
bbgwrbgrguburrguurrbubwbubwggbubwuguwwubrggwgbwuuguwurrbbbg
ubrbuuuuubuurrwwwggwuwrwububgrgwrrbbgwruwwbrwgbguwbwggw
bburrrbrrbwgurwgwrwbbgrgrggbgrggruugwuwbbggbgbrru
ubbuubwwrwrbwrwbbggrwuuugugbwurgggbggrwgwuuurgbwgruwbggwbbg
wubwwrwbuggwugbwwuugugrwbwuuwuwgbgwuwubbbg
ubwrwwrggrrwgurwruuwburbuggrbbgubrwwgrguwg
wwbwrgwugbgwggrrbwugbwbrgbbrurbwgggrbwbrubwgr
bwggwgbuuuurwurwgbrwguurwbbguwbrguwrgurubrwugrgugguuurgbu
rggrggwuwwgwgbwrubggubrgwuwugguwuwrwbwgrru
rburwbbuguwugwggruugwgwuuruurwwwbgwwbuwubbwbwwwgbrggu
ggbgbrbggugwbbgbwwruuguuubuugwrwrbbrggbubwgw
ugwrwbuwwgbgwuugguurburrgrggggbbwwwurugrurgwwbbugr
rggwuubwruwgrrbbbbwgrgubrwbbgubrguburbgwwrrbgwbrbgubwwrrw
ugbugrurgwbuwrbrgubbuuuuwrrwrrbwuwrwrbbg
ubwuruuugrggubbrrwrrgwruubwrwbuwwwwuwrggurgurr
bbgrwwwbwbwrbgurbrgwbrwwwgrrwrwugurgruwubug
wrbruguugwggwubguggrbgwuwbwwuuuwwugggwwgrb
uwrrwwubwrwrbgwgrruurwgbbbbbgrrgbrbgwgruwbruwwbrwbrr
wrugbrubrgwgbgruwrbrrwgwrrbugrguwrwrwuwrrgu
guwrubbgrgbrwurwbbbrgwubwrwwbuwbrugbbbrbguruwwg
ggrbwbuwrbrbwwrrwwwguwgbuuwwgrggwbuwwwugrgwwrrru
rggbrubrugrrgwrrwuwbubbgggugwgbuububbwrgrgbbwrgw
uuurrbbrrrwrbwwwwbwrbgwbwgbugrgrwuwburbbrwrbrwur
wurguurbrrbgbuwuwruwgwurgugwbwbgbwurbggbwbruubbbbgbubwg
grbwgrrgrugrbbububwwruguubguwuwuururwggrbrrrwb
ggrbruurwggubrwruwbrrgwwwgurwuggugwbbgurbwrguburrgw
bbwbrrwbubwururubwgrwbbgurwuwruruugrgrbwbbbg
bguguurrrbuugburubgburwuuwbgwgwrbwbguurwrwggbrrwrbwbbg
grwwwuwrruuwbrbwbugbwgbuuggbgbbbgrbgggubgrwwuwuwwrubrgr
bbrwwrwuruubrruugbwburwgubbbgwggrggwwuwrugbbbbbg
wuuuguugbggrgrbwrubruguwurgrrrruwggwwuuwbbgububgbwbgwr
rgurrbugurgubgbwbgggurwuuruubrubbuwbgrbgbbuubbg
grgwrugrbgwrgburgbbwugbwbrrbbwgrrbwgbuwrgugrwubg
wbgwgwwwbwbubbbgurbrwrubbrwrbbbbrurguurgwuwggu
rgurugwbruguuggrbbgwwurrbbgbwuubgrugwbbrwwrrbbg
rurgrgrgbwubwrbrgbgwruuwurggbwggrruwbwuubbugg
uuuggwgurgwgrgrwwgbuuwggurbwwwbrububugbgrubgrrrwubbg
wwbubbwuwwgwwuwuubgwwbrwwrwbbbggrrwbuwuwrwgwgwubbg
wugwruwwgrbubwuruguuwwwwgwuugwubgurgrrwrrwubuuuggrgu
wubuwwubrgwuuwgbbgrwbgwrwbwrugbruggbugrbuwubbg
ggbbrubrgrwrgwuwwrrbgugguuwbwbwggrbbwbwbbwurbuwbugurrr
wbbbrbwwubggrruuguwbrurgwbbrrrrrwbbrwurrgrugbrwurub
wrubbbuwbwgguwbrrwrbbbruuruuugrrbwrrbruwbwbggrbggrgbbru
urbbbwbrbubwgrrrwrgwrugrwrgggguwwbruggwrwrruurbgr
gggbrgrrgbwbuwbguwuguwguugwwggbrrubbgrbg
ubrwgbbuwubrggrrbbruuuruuwurbubugbrbgguwbwwwuwbbg
wuburburwrwbrrwbrugbwurbbwugrugbrbggwuurubbg
bububugguuggbrgwgrbrgbbgwwruubggbggbrwubbgrbuwwru
rwwwwrubuguwburubwubguurwbrrwwbgbgwbrugugwrgwrggu
bbruugubugbrgururbbuwubbwbwbgrggrbruwwuwggwgbruggbgggg
uuuuwbruugugwgwwwwugurwbguwbrwgguurgwgruwggugbrwrgr
bbrrgburuwrwrrbbbuururrrwbgurwuuwubrguguuwuwgububugrbugu
wbbggwbwggbgrrugurbgwrrburbuubrwruwugrbwwgwubbg
wruugurwgbruburgbruuuugwguubggbwugrrggrurbbruugrg
rubbrbubgbwwbbbgbrrubwrwwbrbuuwgbwubwwrwuggrrrbruuguwrwuub
ruwggruugruuuuburbugbuggbuurbbwrgguwrgbrbrbbg
ggwurbuurruurguubwugwrgwwbbugrwwgwggwwbburrgbggggruwbgr
uuubrrrgwrbwgbgururuwwgwgbuwbuwggggbgbwbrgg
burgubwburbwwgwgrwurrgbburubbrwguwrwgbrrgrbwbb
wwwwuggrbbbwugwgwwwgrgwugrwbbrbuuwggbrwgwwrrwwwrwg
urbrrgruwwrgbgwwbguburuuubbbrgrgubuuwuwrbu
gwwwubrgwwuggugwwurwbgbwgbwubbuugguuugubbg
wrwgwrrubbwbrwruguurbrwbbuuurrwbbbgbgwubwbbbg
uurrgbwguugbwubbuwwbubwwbbgrwbggbwrgubbgruwr
brwuwwgrrwurruwgrwugrubugrrgbgwgwrwbgwrgbuuruuugg
wrrrgrbwgrgrwwwwbggbgguggbbrugwwbuggburbguubwrbbrbgubbg
ubwwuwgbgguwggugwuuwbrggbwrrgbwgurbguwbrrbwbrrwugwwrubwur
wwbgguburggbgbwgbrugrwgrubbrurbbbuwgbrgbgguwbwgw
wbuwubwgwguwwwrrrbwbgwgugbubugguuwrbugurbubwbwburrbubbrurb
brbwrrgrrwurbgwggggwgrguruuburuuwuwrwwwgbruuuwbrrgwwgrrggw
bbbwuurrbwgwugurbrbgguwgwrwbwuwrgwwgwrggurwubgugrr
uburwguwuwwwwrugwbrbugrrubrgubwbrgwugurrrgwruwwbgrg
wubgrrwbbbgwugwuwuwrgurugbrwgbgbrwgrbbgwgu
bbwurgbwubbwgruugugbbrwuruwwbwburuurgggrbbubbg
wburgbwbugrurwwuwwrrbwbbrugbubuwurgbgwgbwbgwbu
bwwgrubgwrrrrbwrrrwbuuugugrwuggrgurrrggrbggwbrbgwbbg
bgbggwbwwwwgbbrbwugwuuugrgbrurwgwbgugrrwbwbuwgbgbbub
rbuwrgbrggbruwurwbrwbgbgrbuwrrwggugbrgbwubgwuggrugwwgurrww
rggbwrubggurwrubgwugbwbuugwbrrggurggguuwwwbwwwrubrgrbrgu
rgguwwrgrgwwurggbwbwbwgbgbggbgugbbbwrbrgbwbbg
wugugrwbugbwbugrggbubuwwgwrbrwgwurwrbbbg
bgbwwrwurgwuuuwwrbwrbugrwrwrwwgwwugwuuwwbwbugb
grrubwrwuggrwrgwbggbggwuubgubrrrrrbgggurrrwrw
burruwwbbbbbguuguuwrrgwgwuwrrrrubgwrbrrwwbbbrgu
rrrgrrwrrwbbwubrwuugggrrburrwwurgggrrwwrgrwwuu
grbwrbgwugrbugbrbbgbwbrrrrubbgbgbggbrrruwuwgwbugu
uuwwggwwrgurwbwgbrwrbbgwubgbuuruwgwbwbwwrwbugrbg
wbgbrurrguurrwruwuubbbrrubwurbbbbbugbbguurrrgwrgb
rwbbwbwwuubrbruuuwbgguburgrburwbgwbgugrurwbbubrb
ubwgugruuuwwrwbgwgwbrggggrwgbbwrgwrrgrbwbbgrguurgb
bggrrgurgbgubgbugwrggggwuurbruwruugrbbrwbbugugru
urugugrubrgubwrrrbwugwururrwuwwrugwbgwwuubugw
wubuwgwbwgrbuguwwubwrbuguwwbgwrrbrrwugwuubrrb
uugbrruburbrrrrgrrgbrgbruwbgwwbrrurgguwuubbg
ubbwgwbgwugbwgwwrwbwbrrurguurguuurwgugrggbggwgw
urrburbbrrwgrbgwggrugggbugurrburwugugubwwwrrwrbuggwgwuuruw
wbrwuurggbgguruwrrgwrrrrbrrwrbgggrguwrwuurbbbuwgrurwu
rrrgbbgrbwrwrwwbbuwrbguuwwurbwggwwbgwbwubrgwwgruggww
bwgrwuurbwbwbrgwrwgwgwurugwrrrwuugrgrruwwgrru
urwubrgwrgwgbbguwuggrwuburuwgggrrggubwggbg
gbgguruubbrubwwruwwgwguuguuuuugwugrwgwuuwugrww
rwrubugrguurggbgrugrgbuubbwwuuurbguggrwwgwggwuw
guuuuwuwgrubggwuggrurgubwrbwruubgwbbugwwuggrgwrbug
wbbuuguguruuwubuwgwwwbwubgwrbbrggwbbrrgbbbbuw
rwruuubgburrguruugrwwruwrrubwbwwrgbrubwrgrbgwgwurbggwugur
brwurwuubwwrwwgwwrwgrruburuwggbwbggbuugwuu
guwburubwruubwguurrbwurwgwuwbguuruuwwgwrwuuwbrrbugg
urububwuwgrgrwwrwrwbbggrrrruugrrrugwbbbrubwbwggrguggurwrwbbg
uruubbwurwrgrgrrgrbburrggwwbwwubwrgwgwugwwbburbgrrgbwb
bbrrwgwrguubbuggwbbbwrrrurrguwrbggbbubrrggggwrwbrg
gbbggwrrrgwrrrggubbbbuubwguuugubggrwrgrggbuwbbg
gwrwbrgbubbbrugwgruuggguburbbgruububgrbbg
rbgrruwguurwurgwugbuugrrggugbuwrubbrgwbuwggubuurgg
wugwwgwgrbwbguruguguurwrggubrubruwrrugbbbwuubwrgwwgr
bwbuubgbwwuwwggwgbburgugbbrgbuggrbubbgwurrrgur
ggbgrwgwbrgugwwwubbbubwrgbguuububuuburgrwgg
burbwuwbrwbwrguwbwgrwruugggbrgwubbwbwrubbbbbrurrgbbrgrbwg
bgrgugrwwggbbrgwgbbgbuuggguwwwwrrurbwwgrwrbbbbbbw
rubrbgbuurgbrrwrbgrrwbbbwgbubguuuggrwgwrubgrrggguwbub
bbwubwrgguugubwbbrwwgrrgubbgrgguggwbbbbgbruwgwwg
bwburrwuruubggugwubgbrubwugwugurrgwgwgbbgbwrwuuubbwrwbbggbg
rrwrwrggwbbrwuuwgbrwgruuubggwbbwwuuwwbbrrrbuwggugwu
wrrrgubwwuubrbbburburwbbuwrggbgubgrbrbgrggwrrwgbbbg
grubwbwrrburrguwwuwbbwwwrgubgubwwwwrubgwggbuubggwburggrgrg
rbgbbwrggrgrggbgrubrrrwubggrbggbbwrbwbrwwwguuuwwrbbuuwwbru
gbubrgbrurrwuwgrrbgbgrbrgurrubuuruwwrbwuuurgrbrwbbg
rrguuwwrbubbwggbgbbgwgwurrruwuuwuruuwwwrrwwubrbubuubg
urrbubgwrgrgbrwburrggrbrwrugrrbggrbubrrrrbuurbbrrwugbbubbg
wwugbruwbbwgbwwwruuwgrgwbuugurbwuuggrugrwgbubbbg
rgruugbbgbruubgubgwwuugrggrbugrwbrrbubwwbggbrrgrrbbg
ubuwrwwgurbggwruuruwuwbbbggrugwuurwrrrwrgubbwbgugubub
brurbbbbbwuugbrrgrurgwuuggbruwuubwguwggwugwgwwbubuwgru
bgwgrbrbgbuguwwrgbwwwrgurwuwbrgugbruwrrgbwwbgrw
brggbwwwrbrwwurbbwggwbuuugrubrbbgwbrgrwwwrwwwwrubbuuw
wwwuggggbbbuuwgggurbgrrwurwggbubbwgbgbgwurb
bwuubuuwrwrurgbbubbrwubbuuuugwbgbwuuugggrbruwbgurwr
rurguruwrrbbruruwgurugwugwrrgbwggrbugwrubrbbg
urbrgggwrbbwwgugrrbwrrbwugrugrbrgbruurrwurburwburggbwwww
ugwwbrrrrbwgggggguwbwrwbwrbububgwgbwbuurugbwuburguwr
rbubbrwurbbbwwgbgwgrwbwuurrbggugbrgbuuwubguwgururrrbww
bbbwgrbrurggwbgwgbgrgwwrburwuwbrwguwrbgwbruuwgwrgggu
bwwwurwgwwbwgurwugrgbgrwwbrburbwrgggwrwurwbbrwrgrrwgww
uuugugugguwbuuugbugrbgbbwwgugbbwwwrrugrbbwguubwbbgrubruub
uuuggbgbugbruuuwbgwgurggbbgbwwwbwbwuugrurrugbrwbgw
wbwrgggbrrguuwbuwgrwggbwuwgwbgurbuubugwbuw
bggbuuwurwgbbubbwubwbugwrbugbggggrbwruwwgbrrwubwubugwwwbbg
uuugwbuurgbwwgurwrrwrbrrrgrgrwrbbbuuuuuguwgwwbrbbg
wbgurgurrrgwbwuwbuggwrgrwwuuburwuwwwgggruwwbugbbbg
gbrrruubbwgbuubgbgwrugubbgrwbubgbwwurwruubwgw
ggbubrwwbbuugurrgrgwrwrbbuuwrguwruubrrggrggbwguwgu
guwuwgggbubwwwbrwgbgrrbwuwrwruuubbguurwwwguuruwbgwwr
ubwugrurrguguwbuwggurbwwrggggbgrbuuuwwrurubwubgbgbwguguwg
gwbgubuuurguwggrrguubuwuwbbgwubrbuwuuwrwbguurrbbuwrrwrb
wrrrgwbgwwugrbuubgrrrruuwrgrwgrgrgggbrrurguugrubgwuwbgggwbbg
rrrgwuwubwurwgwrubuurgruwbrwuguubbbwrwrbbggwbwwbww
bwbbbggbwuwrgbbubrubrggrwurbwwbwuwuggrggrrbubg
gruwguuwbrwururrwuuugbggbgugwuguugwrbbggurrwrbubb
uggwuubrgugrgggrrwgrgrbgbrbgbwrwbggrwubwbbuu
ggrbbbgbwrgrwrurgrbgwbwbbrruruwgwrwbubgwwbwbwbuwwgburb
uwwwrwubrwguruwwbwggbrgbrbuburbururgggugrwgrrwgguugwbwwbgg
grrbbwwrgbbbubrwbbbuuruugwwgwrrbggurrbggwwwwrgbr
rgrubrbgguuugubwubrwuwuwgggurugrrubbrubwuurrgg
wwwgwburwrbrwbwwwruurrbgbggubrbruuwbwwbgbrrbgwrww
bubwbwrgrbuwrburwurgwgrwwbbwwgggbgggruuurggrbbg
rbuuwbgwgwbwwwwbbggrwugugggwbgbbgwurwbuwwuwuur
gurwrrubrgwgwgrgbrgrrbuwrbbuwggwbwrwbubwurguuwgwur
brgwrrrugrbgbbwruubwuguguugwbugbuwrgwrrwgurwwbrwwubwggwu
uuurbrrgbubwrwgrbgwbrubuuugguwgwbrwbrruuugu
gurrurwwuggruuwrgruwrbrwugrwwbbbwrgbugrrwbwwgbgburgbguwuw
rruurbbbwbgbrrrrbgrgwuwwgrugggwbuwubbuugbwb
urwuuuggugbbgrrgubbbrbururbggggrrubbbgwuuurbubbgbuwrurg
brwrugbwgbgbgwgwgwuwgggubrbbgbgurgubuwbbuu
uugbgggwbubwrugurbwuwrbguuurgwwbwrrrrgwruburbrgruwbwuuguwbbg
rwrbwubggrgggubwbwgwgbgrugbbwbugrgbrrgwrgrgbwuwruggugbggu
wgrgbrwbguwuurwuwgbuwwrbwuwubwgwrggurrrrbrwwbwubgwg
rrururggggrrrrrbbgubugwrwbgbuggbwugrwrwwgwbbbbrurbrgururgb
ugwwrubuwbuuwwbbrbbrwbwgurgwgugurubgbwgwruurbbwr
wbgrgbbubbuwwgwwuwrbbbgwuubrbguurgbrbbgbggg
grwwuguwbbrggwbbugrbbubwwwwuuurwbgwwrrwwwrrbrwrggw
ggrgugbgbrwgwgubwbrwuruwurubrurugwrgruubbbwruurwbbbg
rwbggbggbwgrgrrbuuwgbrrbwbubruubrgbwwburwbubrrgbgrgggubbrbbg
wrwurrwwrggwwbwrbuurbwwgurbrgrbbugguwbugrrwu
rgubggrubrggbbuuuwrwruurbrwugrwgguuburgurbuub
bgguggbgwwgrbbrbgbrruggwuuwwugwuwbrubbgbwuuggbbwrwguggrb
bgggubwbuuwgrgwrrwuruwwrugbugbwrrbgbrgwugugwwbbg
brruwubwugwuububwrbgbugurrruubggguwbubgrgwrgrrr
wwwbubrrubbugurwrruwwruubbgwwgrwugwbuggubwr
rwrggrrbugubguuggrwwrgwggruggrwugurwgubbg
wwbbubwwrrrguurugurgugrwbugrgruburwurubwrububbggg
gubrwbuwgrgbrbbubwbrrbrbbgrgbubrbwgubbbbg
guwrgburrbrugbwbwbrgwrwgbuugbbggwbguwuwwwubbg
ubwwwburwbwwuurubgrgwrrgwuwbrrrwuruubrurww
rgrgguubgrggwbrgrgbguuubbggrruwbrrruwruggrurwg
uwwgbgwugurubbrbgwurbwubwurrurgbrbrbburgbrbwrguwuw
rgwrgwwwrbruwrwbrgbbrbugbugugugururruwugburgbrwggruburbrb
gbbubbwbububwurggwbugrbwgbwbrwwubuwbuubuugbwbbrw
bwgggwrrguugbbgubuwwwubbgwrbrggrgggbrbwwww
wguwbuwuwrbburrgbburbwuuwbwrrgrurwrwbrgwugubugbbwgwgru
bbrbbwbbgwgrwbrwwgrwrrwrgwwwwgugruubbrbbbbg
rgrwuwrgwrgwbrururbbbgggguwwubggwrrbrururbbb
ggwugugbwggurrwgubrwurugrwgwgrgbbrruuurwugrwr
wrruugwwwrbgwbuurrubrwwubuugbgrbubgubbbg
wgwwgbubwuuwrbggwrrrbrwrbwwguwbwwruuguugurwruug
uuwggugubbgrguwgggwbbuwrgurgwubbrwbwgbgguurw
bwwrrwruwrwbbbwwgggrbrwuuguwbwuwurggguwrubrwwbwuwbbg
bbgwurwggbruwbgbbubbwgwgwbgwgwbuggrwwggguwrugwwrg
uwbwgguwrgrbrgbruubgrbrurburugrugubbburuwuguwgugrwrbg
wgrbrbrwubrgbubgbbbbbwrrgbgrrbgbrwggbgrwwubrbbrrurgruugu
ubwuurggrrrwbgubwwbgwguruurbwrwuruwwbwbgggbuwwwbgwug
bugbbrugwbrggbburubwrubgbrurugwbbwgwggrbbbg
rwruubgrurwrrbugrrubrrwuurwwbrubwrubbgwugrrwggbgurwb
gwggugrbrbrgbbrugbuwbugwrgbrwugbbbwuwwgwgub
rbuuwbbrbbbgwwuggrwwgrgurrwbbuugubwggbgbrwbbg
bugrubwgbbbubrwguuruwwwgrruwbrgurubuuwwburrgubgg
wwrbbuguguwwwuuurbwuuuuwuwwwurugugrbbgbbrwuugbwurbwurgb
rgruugwbgbggbugggrrgggrwugbruuwwwrwggbwwwuwbwwgwwrggbubbg
wuwrrgrbgwrggwwgrwbrurbwwrgrgrwuuuuubwururwggrrbrgubgwgug
wruwbuwgrgbrwugburrrbugrguggwbgrrbwrgugwrbbwbrbrw
uuwrgrbwrbwugwbbggwuwwuruurgwbbubbrrgggrgbrbwwrrurrgrguwbbg
wbuwrbuguwwbbubwrwbgbgrbwwuwruwwuurrrwurgwrwguwgrwur
ugubbwrgwgbbururbuguubwbwugrbbggubgwuwgbuuggw
uugwuuurrurgrugwgwbbwurggrbgugruurrruurgbuuw
gugwbgbwbuwwbuwgrubbbgurgugwubguruwrwwrgrbgbbwbg
wwurwurrrbwrgwurgwwuubrrgbbgbguuggbwuwbbbrggrbbg
rubrgwwuwbwubwgwuurrrbgwugwwrwubwugwwggrbrrwggruurbuwubu
rgurggrgruwrguwubwgrrwrrrubrrbuwwbwuwwwuwgb
ububwrwrubggwuggwrwuuwbwgbgwrguubruggbrgwbrrwug
";
}