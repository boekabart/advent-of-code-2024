﻿namespace day3;

public static class Input
{
    public const string ExampleInput = @"
xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))
";

    public const string ExampleInput2 = @"xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))";

    public const string RawInput = @"
}}+{where()mul(873,602) mul(954,447)^where()~mul(548,799)-<what()mul(588,631)^who()'@( [mul(143,388)how(445,327))$ select()who()mul(746,719)mul(963,262)}'*+why()<?&/select()don't()[%]% ^^mul(933,492)don't() ^-who()(%how()]mul(583,700))!,where()mul(999,507)](mul(821,504)^%/;:-mul(471,220)who()&'who(161,37)<'mul(843,213),<mul(298,802)-()@how()where()@+[:mul(910,85)'when()($select()%-*mul(532,213)*from()select()$,what()mul(956,380)mul(326,87)mul(243,775)!/:from()&^^mul(118,409)!)what()select()mul(610,89)mul(432,774)from()# from()<mul(400,864):+&mul(957,923)'don't()+select()why()mul(496,383),&why()(-;)+!#mul(79,135)~{mul(500,619),#what(361,47)@&;@+mul(580,98)<>#why():$from()(!mul(660,615):where()mul(596,918)how()[what()how()who()]@mul(594,699)$>$&why()mul(951,813)mul(948,41)]mul(699,225)>mul(840,275):@~^@%^select()mul(695,594)what()->-mul(409,636)@ {++mul(999,290)when(339,689),[+[+?mul(558,848)how(),what()&}]{mul(344,337)$)$]+,$,,why()do()::select()^:mul(796,16)mul(526,718) mul(66,417)#@>~do()why()from()/select()when():&mul(8,111);!where()do()}@mul(433,239)*}how() {^!do()#^mul(167,905)-&%(mul(979,711)when()]who()'?mul(523,172)[^what(844,455)'what()[/~@mul(928,776)where()]&/mul(587,380)who()/when()how()from(),}#}mul(97,952)select(837,505)~@>~%mul(486,198)^!mul(968,779)do()[mul(206,321);,where()where())how()}/mul(6,867)-&<!*select()mul(615,984)~?who()#<{how()?@mul(617,643){ @,'why()+>what()(mul(683,583)^(mul(244,555)^where()(how()what()?-[,who()mul(827,305);&,!$*?mul(793,452)^ )+(%-where()<mul(318,238)<$-what()mul(802,394)?how()<mul(488,879)do()$}<:&mul(429,358)~how()mul(36,174)mul(87,398)+%what()]mul(822,311)mul(379,261)~when()mul(618,193)@)!))-what()how(645,829)[mul(964,102);who()don't(),[what(),,?select()why()@mul(121,293)select()@who()!mul(770,96)+;%from(467,168)mul(616,890)@%:)[mul(943,145) [from()&where(283,130){*where()mul(649,49)select())mul(877,73)from()do()where()?where()>who()from()@who(){*mul(592,919)/:what():who()mul(213,139)what()$!?*how(934,24)$-who()(mul(661,7)?from(),}/who()mul(876,585)how()why():when()[@@mul(433,918)why()why(),*{who()when()who()mul(144,14/#(<mul(656,306)&what()&{*@%select(709,225)/mul(843,135)who()$[don't()<mul(576,966)^,?>don't()@(@{~why()[who()mul(394,492)where()/mul(508,797)-mul(150,832)+$@why()(why()~mul(527,236)<don't()!#{how()*!,!mul(177,945)'mul(5,181)#!#'&?what()&mul(10,492):%/'*mul(822,748){!*]who()when()<!<mul(21,920)+do()-who()from(505,694)where()from()$who()where()where()/mul(827,561)how()when()mul(770,221)%when()who()mul(872,151)mul(453,84)['&+:mul(258,293)@#,where()mul(264,689)mul(90[mul(94,665)-who()don't()what()>!:@!^&!mul(324>?!from()where())mul(731,184)#(}who()'mul(666,377)how()(;mul(346,141)^select()/@[$how()@]?mul(702,502,^where()<}[mul(872,308)+^!<@from() {:mul(537,974)%when()when()%mul(563,805)select()>how()>^';mul(643,555))where(290,606)who()?mul(656,803),?$/*?when()}@ mul(228,902)~/from(){where()what()>@~mul(849,93)~+select()?-^}<don't()mul(844,117)(when()~,}# /:+mul(24,282)@where()~from()($what()what()*<mul(886,107)[#;mul(725,121) %[>mul(115,425)${what()mul(219,305)how()])from()<mul(401,458)-from()+mul(92,705)
}?/,(~+^mul(398,379)why()-!why(){}mul(618,341)how(818,559)'%}~+}'!<mul(128,74)*- &}+[mul(830,201)$when()mul(382,164) />select()~]~mul(41,659)<'{where():#+)$mul(447,137)where(120,771)$@why()#mul(457,857)<$from()$(who()@?mul(644,914)}mul(936,442);{*(why()mul(804,26);don't()why(),+*how() @:mul(668,778)%select() who() (,where()mul(66,974)^)when():$who()mul(832,615)#mul(572,646)where()how()what()when(673,330)where()when()&/mul(820,446)$why()where()mul(86,788)^~what()'mul(76,413)&'how()mul(616,424)what()select()}from()(/;mul(651,36)!{ mul[*mul(469,702)who()?;mul(331,879)?*from(54,751)who()#+[ mul(182,296)where(607,734){mul(920,190) :mul(660,732)^who()who()*'!mul(3,615)+{why(168,603)when(), mul(254,713); where()*from()~ !!#mul(897,311)]mul(629;what(280,32)>mul(194,563)^<how()when() }#<mul(27,237)?@where()mul(389,541)}'@when()}(*how()mul(671,516)do() ~select()!*']>&mulwho()when()'!what()why()?'}}!mul(414,213)$when()]+{why()mul(606,917)how()*?^,mul(292,543)>mul(326,145)*(&!;^:!#'mul;#@~where()<mul(81,169)mul(436,774)+when()%+where()-[}+mul(425,438)when()/}what()mul(76,978)>%;,from()select()mul(39,372)~[when()what()!+#who()]~mul(905,968from(843,581)(from()from()~what()how()when()mul(768,210)*mul(68,62)mul(777,345%{/select()%mul(458,251));what())how()where()how()when()mul(810,199)<~mul(252,749)don't()mul(915,327)(: mul(608,270)<%[!}-&mul(328,665)from()>*)how()mul(836,471)mul(270,799);(why();&~~mul(598,772)from()>mul(409,297)$mul(469,982)mul(457,665):@>{don't()why()<+,mul(293,172select(816,987)}why()mul(372,420)why()%mul(105,735),<]{mul?{$;>from()what()-$;mul(348,90)from()what()~mul(634,662)^do()$@]*)~,&mul(226,996)when()%]what()!@/&mul(322,135);who() &^select()*&}mul(967,104)from()}'who(701,7)~%[mul(687,163)@:<!how(){^/who()@mul(497,664))@!-(who()<mul(20,274)where(){%<where()?>+:mul(382,128)mul(831,450)mul(485,444)%^what()what()[$what()@}do()-%?'mul(204,152);$'/mul(63,376)mul(387,70)~@'{,':<mul(517,687)@ $^ )why()!mul(865,593)where(918,337)!;mul(786$$'$%why()select()[~$why()mul(667,335)~{+where()who()?from()mul(582,456)%,from()[from()how()mul(927,806)+(]?%mul(460,721)^^;^do(),how()when()select(435,369)}&mul(66[*how();>why()(%{how()<mul(997,260):'do()%::&what()}*who()mul(506,521)'who()%/!why()*&!don't()#@&mul(538,407)'^mul(84,106)'},#^where()%mul(105,225)-what()/how()/from()mul(49,421)@$)[)?why()'#}mul(707,127)@when() &(mul(732,645)'from()'*when()why()from()[who(850,51)?mul(566,427)how()>who()]',from()'how()why()mul(42,665)%'# [}mul(684,645){{%'mul(115,930)mul(552,181)mul(762,163)mul(202,193)+*[mul(525,337)+}-:](?^#mul(466,861)/do()'(;mul(860,319);mul(48,137){when() ~:< <mul(317,942)'~&#how()^mul(66,243)/(from()mul(678,119)when()!when()>from()mul(3,497)?when()< #?^@do()>;/?:mul(522,894)+{+mul(419,20)mul(139,677)where(119,273)*what()[^?mul(563,549)how()<@'%mul(560,434)what()where(),mul(886,302)mul(632,393)*what()!}{mul(769,651)'(mul(267,514)-[how()^:mul(64,902)when()mul(356,352# ;'mul(267,302)#(mul@;~+mul(471,643)!from())!what()from()~mul(429,997)/-mul(401,220)>{]what()what()@select()},mul(294,298)how()mul(230,3)/&what()]>]!how()/mul(888,907)](#>~}+#mul(17,816)/[+when()>from()]^:mul(94,85)
#)'{mul(531,103){ {where()what()from()mul(127,712))what()<mul(595,154)~>!%from()'/how()*when(940,337)mul(259,916)+}!-}[mul(703,780++;select()?why()[{mul(221,199)+mul(303,268)$don't()'[what();^mul(542,561);who()&,mul(68,800)[<'{}why()?^from()mul(26,194)?]who():;mul(641,921)#&where()mul(539,571)select()]~%%]when())mul(833,642);mul(209,564)}<^)when()mul(648,430/(#)/?(';where()what()mul(818,526) ]!what()do() <;:mulfrom() @-<select()what(557,962)$%mul(83,808)from()% {)mul(894,523){~?@'&,how()>mul(764,627)#/mul(887,607), do()$(},#^}}from()how()mul(184,287)where()$^mul(859,310){who()how()mul(692,592){>?&mul(223,912)what()^@ {{^@/mul(736,965)$)]];-#@&mul(600,145)~/}*-}how()mul(893,646):where()}mul(205,416)what()from()mul(35,844)mul(94,245))/<#</$when()who(236,448)mul(943,490)^?*!mul(187,639)select()mul(105,840)#;-;((&,select()mul(495,135)don't()when()(&mul(129,293)}}{~from()]select()*+mul(724,202)mul(540,481)+when()$><from()?$#mul(604,366)where()why()^select()mul(82,14){]what()##/^mul(661$mul(576,422)!}*mul(968,267)mul(501,251)<[,mul(999-mul(61,600)how()~ how()#&mul(488,199)+})who()# @what()mul(695,154)!{[don't()mul(454,729)what():(<%mul(656,115)from()!]when()when():?,mul(536,421)}select()when()<mul(550,82)(:mul(482,346)}%when()>+mul(189,780)from()how()#< ^don't()why()&who()where(){ >:mul(638,986)*+< ;mul(131,393),how(419,400)*@how()mul(856,729)who()$$[$[select()~<mul(553,105)why(720,700)']mul(780,579)}what()select()who()~//}^mul(811,393))/<#,mul(530,118)@'%<~mul(640,727)'-]:-:]+mul(124,151)~@{why()@/why()mul(523,641)'%select())/mul(70,234)-$#mul(589,488)^:how()(when()mul(66,473)$/!-{from()%]#]mul(417,212)~>{(when()$mul(613,175)}mul(503,337)~)what() mul:!-*}?~who()<mul(709,759)}what()^where()when()!select(820,39)]::mul(884,175):#mul(852,584)>-mul(649,886)+how(738,973)when()[(mul(593,702)where()%%^(]who()mul(456,697)%~^'when()how()mul(789,446)mul(737,439)mul(830,910):>why()when()how()'?]why()>do()#'&why()'from()mul(972,441):mul(157,521)mul(43,224):$who()>select()how()mul(52,740)'mul(136,716)select()mul(613,433)]>$^when()why()where()how();mul(978,314))$mul(695,29)}mul(778,660){how()<+$?mul(402,606)select()+~$do()mul(262,94)how()why()))#'^$@mul}mul(201,86)*select()mul(876,626)why()mul(174,750)where()(from()(mul(433,335)]@mul(29,940) :~what()$}where()select()mul(416,920)^&%<~^mul(276,648)mul(636,17);why()}-}mul(810,73)<@} how():from(900,831)what()mul(241,497)select()when()'&{mul(603,108):[,mul(941,454) $@mul>@<}'[, $mul(510,523)where(), ~];mul(584,102)<when()mul(907,301)]#select()select();{how()select()what()?mul(980,625)select())where(){:^mul(544,917)((how()['who()mul(628,364)who(272,887)@!^@{+~{don't()when() )(from()what()when()-mul(95,412)(mul(127,442)/mul(658,920)from()from())!$<&*mul(45,446)what()where()&![-% (%mul(304};do()why(81,149)#^mul(181,603)where()^;{(! ^;mul(381,353)~@$mul(129,558)where()?from(): mul(573,183<how()*how()(#(mul(626,301))?]/)how()mul(20,851)[$when()*how()mul(42,787)[! )@;:(;mul(98,614)why()mul(692,723)!'>' do()why()<&select(812,485)!mul(538,458)who()why()^'select(){{why()mul(773,196)when()why(713,26){,!do()?why()!when(),?mul(234,541)mul(558]!(%;}'-mul(721,55)
(<%@$?mul(856,705]>!#'++why() >#!/usr/bin/perlfrom()mul(147,188)<?$when()+$where()%mul(894,439)>where()what()mul(221,687)/)from()'[{mul(9,723)[{/?who()where()mul(113,227)> ~>$)mul(663,198)&[>#mul(567,600)]when()$@select())(%<&mul(472,423)#when()>(/]select()$;how(511,981)mul(785,371}-how():$where()(?~mul(731,455)mul(810,191);who()(@>,? !$mul(534,231&don't();]why();,#;where()[,mul(190,923) }when()mul <mul(909,876)[*~when()]mul(739,708)select()(@:~)/<@,mul(794,354)<mul(874,298)what()why()$+mul(669,535)&!^mul(260,4))mul(641,230)mul(516,429)'mul(141,983)!}when()select()where()+}[)do()&>:mul(525,573<{what() *$?from()from(){mul(885,340)why()>mul(398,414)?[where()<what()from()^mul(746,645)where(586,97)+'mul(523,150)/%()~how()where(580,13)@mul(446,624),'-mul(605,440),from()$/-where()mul(17,117) >$why()from())mul(988,667)mul(828,197)'why()/%*when()/*mul(799,415)where()]<~ ?>'-don't()^[(' ]%^~%mul(122,243)why();[how(951,959)how(435,882)~*-#don't()why()[what()what()'mul(218,944)!)&>'(where()+mul(686,595)#&when()mul(916,990))what()mul(414,411)>why()&select()!}why() ?>mul(820,386)select()mul(324,473)mul(690,413)!>$why()mul(23,907)who()%<who()))how()^mul(65,111)where()^$mul(793,643)&who() mul(481,441)+<mul(796,772)#^mul(827,58)]{where()*#>mul(579,551)where()when()how()?~&@-why()>mul(359,283)[don't() }mul(238,664)!]~^^#(why()mul(128,702)mul(750,811)what()',do()'@where()select()from(),/+&mul(640,613),&%+why()^from()from()*mul(314~${~*how()?what() mul(593,269)who()*mul(865,609)what()@~$+mul(784,462))],;;'what(){mul(902,580)when()<{~ ?>~how()mul(22,360)]mul(650,584)#select()!(why()/;+when()mul(173,450)where()mul(126,232)(?@/^how()why()who()mul(148,272)&?when()where()]mul(93,105)?!}!:@!mul(428,270)- where(179,717)>@!-,how()why()don't()!where()who()$:<mul(439,76)*,^mul~mul(69,32)!how()}**what()mul(496,817)when()*how()^+~how()from()mul{]&when()-:}why(540,134)>mul(472,276)<'&where()mul(334,580)'/-?+;(-mul(78,731)select()mul(584,89)*/>don't()/;''~how()?<mul(106,855)']mul(996,656){%:mul(873,777);how()(:#mulwhere(939,627)#^><mul(186,441)when()+?who()'$mul(297,888)how()%'?:-{&mul(291,979)}># how(261,707)$],mul(983,656)*> mul(340,628)]*][[/mul(193,206)(})~mul*/-#mul(976,903)%#why()$}-&mul(734,303)what()[from()*-/why()do()&why()!*]@from()&when()mul(339,902)from()([,[*^?how()mul(2,449)when()how()why()mul(799,379)-!#-mul(704,107)mul(205,807) :mul(787,710)mul(575,659)when(),];~'!mul(755,669){+&%$-<mul(533,448);#from()how()$what()-don't()from()] )mul(663,118)$from()$;who()do()#from()*?from()%mul(521,701/how()mul(357,734)who()from()+select()who()(*{%:mul(900,877)[{mul(276,197)!how()who()}$}?mul}$:why()who()who()mul(635,783)mul(276,497)[select()how()select()>,where()}# mul(555,644);^who()!}mul(341:@#{mul(135,278)where()how()what();where()mul(439,633),]$how()why()mul(708,508)where()%{why(744,659)mul(700--(why()*%/where()#<@don't()$?mul(39what(),#})$ select()how()~mul(847,132){)what(134,971)what(336,162))&/what()mul(470,625)#mul(275,789)where()<]mul(15,846)when()from()mul(21,575)%from()^<from()@-}from()*mul(437,525))+!~{select()don't()>when()when() ~(+select()what()mul(554,360)from()]~mul(785,136)}%#:?mul(117,254)who()do()% %;%-from(747,86)how()^/mul(313,607)why()mul(678,806),(mul(226,595)#%mul(415,823)']mul(873,709)#;select()'<> *mul(121,496)why()who()what()?where()mul(590,916)',/@what()how()?%mul(477,943)when()who()/';%mul(654,383)select()*why()'^select()]select()&mul(433,312);//~++what()&<?do()who()^&from()#how();[[#mul(512,521)%>![]mul(532,452)
 +*<@;mul(470,836why()who()select()#when()select()where()from(812,299)</mul(987,617)when()&%;mul(85,662) select()select()*?>mul(469,324) select()why(){mul(891,321);'&$%@{mul(792,73)$$[who()>[[from():mul>why()?how()mul(522,233)([%select()mul(195,940)&mul(368,872)~}{who();!!>^^mul(920,394)^,select():?!%[mul(477,578): what()~!/select())who()/mul(976,739)>;who()who(43,925)&when()>>;+mul(857,247) mul(442,620){;mul(393,289)-!*mul(848,511)?how()}@mul(290,212))(~+#~:mul(150]*/>who()[>?:<mul(289,261)><]*[;+what()where()mul(307,698);;from()~%;where(84,170)[${mul(158,165):[what()^select()mul(977,383)'*@<! )mul(188,493)mul(566,212)&,who()]do()mul(644,488)how())+]~who()where()mul(113,502)mul(306,625),] ;/#&$;who()mul(418,801)#>>/;:mul(920,657)*how()when()mul(816,293)select()~$+^+mul(420,667);(^where());<from()[,do()'where()/!where()&?when()>mul(402,31)]mul(272,313)^>mul(161,164)@$<mulfrom()$when()<mul(718,501)+-who()mul(960,325);who()&{?mul(615,493)select(){]when())#{from(465,35)mul(905,145){[,&>$mul(260,136)&@}* > -mul(380,442)^#*!don't())?(;@mul(209/%(>,how()^mul(423,410)from()-mul(381,141)+~-)mul(674,158)^:what()>(^)who()mul*^,mul(74,315)!-),mul(341,503)where()/;*)why()),what()&mul(624,435)mul(880,482)}where():<select():^>]why()mul(367,134)when()(when()mul(166,251)@+,who(),mul(610,271)+>)(mul(455,461)>&@-()from()+]mul(232,944)&,@when()@]mul(523,215)mul(876,836) mul(335,254)<#-{from()^mul(153,522)what(52,828)who()where()from()from()@&>$mul,!&<don't()why(768,688)what(),);'mul(851,963)]&;(mul(45,859)[;select() ~%]when()!where()mul(807,272):#from()mul(943,224)?$mul(415,924)'from()?mul(204,131)}(>what()^>*{'mul(670,505)$mul&&/<don't()why()@#(*~/:>(mul(672,267)mul(540,120)<$[->!}mul(234,539)!%]who(){mul(30,143)*mul(545,761)where()'!how(935,4)who()%'{~mul(673,752why()what()^:mul(111,407)from()}mul(860,90)#who()/^!how()-!{!mul(217,327)what()!'where()mul(729,143)where()!how()#mul(362,874)$how()how()->who()~^mul(315,718)!'-@~mul(206,449):/[??#mul(185,796)]~mul(597,268);) >select()from()?)<*mul(516,734)when()what()select()#$select()-?,$mul(366,627)%*{mul(62,39)<what()mul(511,35)mul(879,156)-@]from()#select()mul(247,306;!mul(183,347)<mul(638,126)+>^/$from()+mul(250+~select()!from(){mul(981,151)#}mul(92,876))how()who(363,963)mul(827,341)::how()~&mul(407,705)#+>mul(576,849)mul(482,236)(^* who(),what()mul(544%who()('>*!$@,}mul(113,286)when()'from(685,677)do()%from(614,566)-select()$,-mul(234,452)}>[&who(){#from()&don't()why()select(645,338):why(840,833)+#mul(874,529)}>what()select()why()mul(168,89)}{*when()}do()when()*?$^;?)]mul(811,383)!mul(770,725):!*#[from()from()from(487,367);:mul(564,858)(mul(248,563)*:;'mul??mul(254,676)+where()from()?'[){ how()mul(250,339))'!')where()<?mul(410,838)(where()@mul(102,412)where()mul(173,786)-![mul(92,40)mul(888,277)'from()do()mul(390,731)@what()who()@%@who()&&?mul(930,981)>}from()why()-*!mul(740,619)~$when(370,81)where()%-#;^mul(291;^<-mul(266,422)@%select()/why() [mul(794,513)where()>{+mul(944,970)!why();mul(968,484)<from(),:>/what()who()mul(285,45)when()who()^when(),mul(728,164),#/[)mul(568,114)%@:select() /*!mul(763,536)?@mul(506,503))do()@)^/mul(763,386)/why()how()from(417,323)>what() where()mul(260,628)?:'+$why()+@&mul(697,677)+]when():mul(246,278)
 $mul(48,81)mul(266,777)who())@*~!?)# mul(843,750}<what()+>mul(940,128)mul(477,389)who()}:when())<[when()mul(838,845)<when():;*mul(248,817)don't()+what();&/)?>~mul(464,153)why(166,536)</mul(893,554)when()what(){how()&how()mul(505,410)>{/&,~mul(282,701) -!?from();mul(101,631)from()<when()*&mul(187,146)[@+<?{[#{<mul(424,344);!?why()%}what()*>/mul(236,985)why(458,58)do()&*&>how()mul(310,399) :{}^]don't()->when()from()+ mul(389,902)why(301,687) select()}> who()mul(265,840)/mul(652,469)~where()what(){<>~mul(792,402);> $+@select(747,467)[mul(720,836)%what(984,399)[select()-+{}}mul(757,143)-)%from(),)+where()mul(810,426)<!*mul(596,769)$ from():]how()mul(67,919)why(485,244)]why(506,511)how()&,[{% mul(794,823)!/]-*<'where()mul(872~%how()$<}]}why()~how()mul(413,924)?+[>#who()^@mul,]-'(^^>mul(30,409),)from() mul(916,685what()how(){#/mul(494,862)<who()>-&mul(814,480)!&what()*mul(315,311)!when() @}*%#mul(571,122)~*mul(717,593))/mul(633,314)<^{[%{when()-<?mul(26,322)mul(792;(?:^mul(592,551)&from();%]who()<,$mul(276,734):mul(478,513)]when(637,697){mul& @+'[+mul(848,726)how(),from()-!&,<#do() !-mul(412,173)?''when()select()select();'when()mul(306,288)(!when()how(100,872)>,{mul(571,721):?,@~]select(){mul(275,614),select()/<mul(611,515)how(635,963)select()mul(741,23),select()why()^who(),%#}mul(144,95,why()why()~@^when(555,987)(mul(380,549)%:%&how()&mul(19,964)where(),*why()#%mul(194,612)}+^when()[mul(491,112))//what(){#-:mul(239,5){,?>{[@mul(965,299)what()?$where()(#,(?mul(642,519),+~*]mul(830,103)/]:mul(61,609)from()where()from()([mul(808,331)$mul(885,259)))}mul(902,561)$*:mul(320,613)[where()}mul(374,288)~mul(720,106)*~$mul(967,879),who()[what()}when()/#$-mul(81,187)mul(368,22);];<}- @{mul(882,60)#select()when()mul(144,567);what(),,#don't(){+from()'! mul(608,319)(mul(225,187)%%(<,@#+%select()mul(130,278)!select()}<when()where()mul(348,92):from()[mul(483,262)don't()*+&&}$mul(500,537)%(what()what()select()+^;do()where()]][/%select()*mul(118,729)+;[!why()$@mul(155,535)}from() ^*#select()how()'mul(685,187))*don't()what()(&/{mul(174,160)&+~:mul(100,237)<mul(234,939)mul(328,456)mul(427,653))where()why(162,868){,mul(58,176)'}why()from()&'why()?mul(449,899)-when()how()what()do()#,{,mul(529,302)?<]'*how()who()*~mul(382,944)mul(348,909),]/mul(595,427)-:mul(896,889);-)<mul(212,114)[}what()#how()mul(796,319)from()who()mul(161,245),mul(211,760)]*<+]where()mul(239,248)%mul(634,18)mul(501,317)why()#[who(542,47)what()*who()~,$do()}} where()*~[when(696,90)~when()mul(736,662)*%-$select()-$who()/mul(297,910) when()(when()>'@mul(353,117)]%'-^/?^mul(799,639)who()}-[>mul(495,249)where()*,<mul(79,846)how();mul(317,217)/mul(699,367)when()}mul(390,121),![,+]//,don't()@{what()(>)~mul(768,867)why()mul(305,695)don't()?]where() ?#@(who()mul(748,367)why()+[mul(643,18)})mul(343,964){'mul(287,548)?%do(),from();/?';select()mul(97,411)!!{?mul(105,759)how())how()@mul(663,882)~[mul(709,411)@;]what()when()mul(267,470)&mul(857,988)}/]^-select()]^:where()do()why()where()]-*mul(566,77)-<why()how();:~>#mul(217,308)what()~~(select()&mul(462,131)<+]%how()select()mul(242,763)'select()why()mul(316,185)[when()/ mul(584,440)from()
";
}