﻿namespace day24;

public static class Input
{
    public const string ExampleInput = @"
x00: 1
x01: 0
x02: 1
x03: 1
x04: 0
y00: 1
y01: 1
y02: 1
y03: 1
y04: 1

ntg XOR fgs -> mjb
y02 OR x01 -> tnw
kwq OR kpj -> z05
x00 OR x03 -> fst
tgd XOR rvg -> z01
vdt OR tnw -> bfw
bfw AND frj -> z10
ffh OR nrd -> bqk
y00 AND y03 -> djm
y03 OR y00 -> psh
bqk OR frj -> z08
tnw OR fst -> frj
gnj AND tgd -> z11
bfw XOR mjb -> z00
x03 OR x00 -> vdt
gnj AND wpb -> z02
x04 AND y00 -> kjc
djm OR pbm -> qhw
nrd AND vdt -> hwm
kjc AND fst -> rvg
y04 OR y02 -> fgs
y01 AND x02 -> pbm
ntg OR kjc -> kwq
psh XOR fgs -> tgd
qhw XOR tgd -> z09
pbm OR djm -> kpj
x03 XOR y03 -> ffh
x00 XOR y04 -> ntg
bfw OR bqk -> z06
nrd XOR fgs -> wpb
frj XOR qhw -> z04
bqk OR frj -> z07
y03 OR x01 -> nrd
hwm AND bqk -> z03
tgd XOR rvg -> z12
tnw OR pbm -> gnj
";

    public const string RawInput = @"
x00: 1
x01: 1
x02: 1
x03: 1
x04: 0
x05: 1
x06: 0
x07: 1
x08: 0
x09: 1
x10: 1
x11: 1
x12: 1
x13: 1
x14: 1
x15: 0
x16: 0
x17: 1
x18: 0
x19: 0
x20: 1
x21: 1
x22: 0
x23: 1
x24: 1
x25: 1
x26: 1
x27: 0
x28: 0
x29: 1
x30: 0
x31: 1
x32: 0
x33: 0
x34: 1
x35: 0
x36: 1
x37: 0
x38: 1
x39: 1
x40: 0
x41: 1
x42: 0
x43: 1
x44: 1
y00: 1
y01: 1
y02: 1
y03: 1
y04: 1
y05: 0
y06: 0
y07: 0
y08: 0
y09: 0
y10: 1
y11: 0
y12: 0
y13: 1
y14: 1
y15: 0
y16: 0
y17: 0
y18: 0
y19: 0
y20: 0
y21: 1
y22: 1
y23: 1
y24: 1
y25: 1
y26: 1
y27: 0
y28: 0
y29: 0
y30: 1
y31: 1
y32: 0
y33: 1
y34: 0
y35: 1
y36: 0
y37: 0
y38: 0
y39: 0
y40: 1
y41: 1
y42: 1
y43: 0
y44: 1

stn AND ffg -> tnr
y43 XOR x43 -> vfw
x37 AND y37 -> gnn
x12 AND y12 -> knv
hqw AND jmq -> djd
pqv AND kcv -> mnv
gtf OR jjt -> dfv
x38 AND y38 -> qjd
x40 AND y40 -> kqh
ghk XOR pnr -> z09
vjd XOR kmb -> z10
ftt XOR hwf -> z37
x33 XOR y33 -> shg
shg AND gfm -> vqw
jvj OR bch -> jmq
y27 XOR x27 -> hqw
jsr XOR kph -> z13
y35 AND x35 -> rkm
ccq OR hns -> vdt
x22 AND y22 -> hcv
x11 XOR y11 -> mws
ctp OR mdt -> nqv
y24 XOR x24 -> jjh
x43 AND y43 -> dkq
y13 AND x13 -> qmc
swk OR dgd -> tjh
jqm AND fjc -> ktw
fkq OR qfs -> dkn
sdn XOR hrm -> z14
y22 XOR x22 -> hrj
mhm XOR mhc -> z34
rbm OR bjj -> tmm
gqq OR nnk -> stv
jbc OR mnv -> z32
y39 AND x39 -> gtf
crw OR bbv -> wvt
y05 AND x05 -> vfm
mjf OR srr -> dpv
y08 XOR x08 -> dnc
x01 XOR y01 -> qtg
y36 XOR x36 -> fjc
kdn XOR fvk -> z29
msp AND shq -> dqc
vdt XOR rjv -> z25
dpv AND mgr -> fvd
bqf AND vnc -> jjt
x09 XOR y09 -> ghk
ckj AND jjh -> hns
mpm XOR gtn -> z21
x35 XOR y35 -> rpq
y16 XOR x16 -> btj
wkh XOR fhk -> z17
y31 XOR x31 -> mbc
gsv AND qtg -> vjb
y23 AND x23 -> jmr
jpj XOR brn -> z18
crb AND gqd -> fpk
x07 AND y07 -> hhm
spg XOR bfw -> z44
djd OR wqf -> msp
gsv XOR qtg -> z01
x10 XOR y10 -> vjd
x20 XOR y20 -> pwm
nct OR mmk -> gtn
hrj AND tjh -> wfs
y13 XOR x13 -> kph
pjv XOR bhn -> z05
fhk AND wkh -> vpv
dnc XOR rtp -> cdj
x40 XOR y40 -> tqg
ckj XOR jjh -> z24
x23 XOR y23 -> crb
y14 AND x14 -> vjh
tqg AND dfv -> dbc
y10 AND x10 -> fkq
kcv XOR pqv -> gfm
x18 XOR y18 -> brn
x02 AND y02 -> hjk
wdg XOR fbp -> z03
y08 AND x08 -> z08
x32 XOR y32 -> pqv
tqg XOR dfv -> z40
jdh OR qrw -> z45
x00 XOR y00 -> z00
gtm OR mqp -> tfr
x12 XOR y12 -> dmv
mdr OR dqc -> fvk
dmv AND wvt -> tkv
gfm XOR shg -> z33
dbc OR kqh -> tkw
x21 AND y21 -> swk
jhb XOR tkw -> z41
dkn XOR mws -> z11
x05 XOR y05 -> pjv
x04 AND y04 -> wmc
fgk AND jbp -> rdf
y16 AND x16 -> dwj
hqw XOR jmq -> z27
gnn OR qmd -> kvn
msp XOR shq -> z28
mhs AND pbn -> whd
pnr AND ghk -> kgf
y31 AND x31 -> tnf
pwm XOR cjh -> z20
y19 AND x19 -> stp
tdc XOR scp -> z30
y03 AND x03 -> tqj
fpk OR jmr -> ckj
skt OR cdj -> pnr
gtn AND mpm -> dgd
wmc OR whd -> bhn
dpv XOR mgr -> z19
y17 XOR x17 -> fhk
y03 XOR x03 -> fbp
btj AND tmm -> z16
stv XOR vfw -> z43
tjh XOR hrj -> z22
y11 AND x11 -> bbv
cpp OR tnf -> kcv
pbn XOR mhs -> z04
x17 AND y17 -> pjm
bmh OR tqj -> mhs
fgk XOR jbp -> z06
x25 XOR y25 -> rjv
kvn XOR qjd -> z38
y21 XOR x21 -> mpm
qfv OR hjk -> wdg
y36 AND x36 -> jwh
knv OR tkv -> jsr
tnr OR hhm -> rtp
mhm AND mhc -> hsq
qjd AND kvn -> bgj
brn AND jpj -> srr
hwf AND ftt -> qmd
pjv AND bhn -> jnn
x42 AND y42 -> gqq
btj XOR tmm -> mrb
x28 AND y28 -> mdr
y39 XOR x39 -> vnc
dwj OR mrb -> wkh
rpq XOR pfh -> z35
y25 AND x25 -> ctp
stp OR fvd -> cjh
cgp OR vjh -> gjd
crb XOR gqd -> z23
x26 XOR y26 -> stc
y44 XOR x44 -> spg
nqv XOR stc -> z26
bqf XOR vnc -> z39
x42 XOR y42 -> msd
x00 AND y00 -> gsv
rpq AND pfh -> bdd
x01 AND y01 -> wcd
x02 XOR y02 -> vgg
x38 XOR y38 -> dhm
y09 AND x09 -> btq
wdg AND fbp -> bmh
x06 XOR y06 -> fgk
qpq OR vqw -> mhm
dmv XOR wvt -> z12
y32 AND x32 -> jbc
rdf OR kcg -> ffg
ffg XOR stn -> z07
sdn AND hrm -> cgp
scp AND tdc -> pkv
fvk AND kdn -> kvv
ktw OR jwh -> hwf
spg AND bfw -> qrw
x27 AND y27 -> wqf
rkm OR bdd -> jqm
x37 XOR y37 -> ftt
y30 AND x30 -> nmd
y07 XOR x07 -> stn
y41 XOR x41 -> jhb
vfw AND stv -> nfk
y04 XOR x04 -> pbn
rtp AND dnc -> skt
jrd OR qmc -> hrm
kmb AND vjd -> qfs
nmd OR pkv -> sjk
tkw AND jhb -> gtm
nfk OR dkq -> bfw
x29 AND y29 -> shs
jqm XOR fjc -> z36
sjk AND mbc -> cpp
x20 AND y20 -> mmk
y33 AND x33 -> qpq
hsq OR fgq -> pfh
gbg XOR vgg -> z02
jnn OR vfm -> jbp
pwm AND cjh -> nct
dkn AND mws -> crw
mbc XOR sjk -> z31
dhm OR bgj -> bqf
y34 AND x34 -> fgq
x06 AND y06 -> kcg
x41 AND y41 -> mqp
kvv OR shs -> scp
btq OR kgf -> kmb
rjv AND vdt -> mdt
x15 AND y15 -> rbm
x44 AND y44 -> jdh
gbg AND vgg -> qfv
x18 AND y18 -> mjf
y19 XOR x19 -> mgr
msd XOR tfr -> z42
y30 XOR x30 -> tdc
y24 AND x24 -> ccq
x28 XOR y28 -> shq
stc AND nqv -> bch
y14 XOR x14 -> sdn
gjd AND jfh -> bjj
x34 XOR y34 -> mhc
vpv OR pjm -> jpj
msd AND tfr -> nnk
x26 AND y26 -> jvj
kph AND jsr -> jrd
jfh XOR gjd -> z15
x15 XOR y15 -> jfh
y29 XOR x29 -> kdn
vjb OR wcd -> gbg
hcv OR wfs -> gqd
";
}