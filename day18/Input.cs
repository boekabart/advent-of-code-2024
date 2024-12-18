﻿namespace day18;

public static class Input
{
    public const string ExampleInput = @"
5,4
4,2
4,5
3,0
2,1
6,3
2,4
1,5
0,6
3,3
2,6
5,1
1,2
5,5
2,5
6,5
1,4
0,4
6,4
1,1
6,1
1,0
0,5
1,6
2,0
";

    public const string RawInput = @"
45,57
67,59
59,59
51,69
27,31
41,12
41,9
60,61
39,53
57,47
23,5
45,67
57,61
27,59
32,5
35,15
43,52
28,25
61,62
16,13
61,65
51,60
53,51
31,22
25,65
23,11
13,21
65,67
21,69
67,62
5,11
17,27
30,7
66,55
39,7
24,15
7,18
20,9
30,5
45,51
47,61
13,22
1,14
21,54
67,57
20,69
9,24
30,1
20,67
20,53
25,59
54,65
5,9
50,51
5,12
59,64
55,65
31,47
32,45
33,34
20,27
25,43
8,5
31,63
21,53
48,51
27,63
39,11
23,3
25,62
47,67
21,60
14,23
53,69
35,8
69,67
21,23
23,66
35,59
14,5
27,11
51,70
33,69
12,63
34,53
25,64
33,23
21,22
44,65
36,61
27,49
25,67
47,56
15,2
29,7
21,13
15,9
40,67
27,52
19,66
41,11
39,2
11,58
27,68
57,65
66,53
11,17
12,25
27,47
31,27
1,10
41,61
6,9
39,57
15,23
37,12
31,68
16,5
46,59
18,53
66,59
66,65
25,7
18,27
22,9
8,9
5,5
49,63
14,47
59,66
45,59
67,27
16,23
37,1
19,69
51,53
39,64
21,65
7,3
53,67
18,33
19,16
21,3
13,11
39,68
37,2
60,65
27,48
50,55
69,62
13,9
28,23
5,25
39,59
36,67
37,7
59,53
22,19
15,54
10,13
12,23
19,13
3,1
17,28
19,29
33,10
41,14
34,9
5,6
31,59
33,25
9,6
22,29
29,41
55,64
11,4
31,69
35,67
23,61
21,19
32,15
24,3
31,64
29,59
35,63
5,14
66,67
19,1
35,22
33,67
26,23
28,51
29,11
59,67
39,61
27,65
10,23
21,63
27,67
25,55
43,59
18,15
40,13
14,59
3,9
37,6
38,1
46,65
53,58
9,18
33,65
31,19
45,68
64,69
40,9
45,61
33,9
29,13
15,1
14,15
24,59
65,56
23,32
15,65
23,68
59,47
1,5
2,15
17,53
42,59
33,59
13,50
11,13
11,10
7,1
41,4
35,55
48,57
53,68
27,55
28,59
27,15
68,65
55,63
17,3
69,51
67,55
39,3
25,63
13,0
69,64
5,3
51,65
33,5
17,19
34,63
5,1
31,5
9,14
35,3
65,59
34,5
31,17
15,55
28,9
18,1
29,51
0,15
36,7
13,1
9,2
15,52
11,63
29,67
1,13
63,64
45,62
17,7
5,2
13,65
5,31
31,12
61,63
21,20
24,7
29,65
27,19
37,17
19,19
27,27
68,57
67,63
27,45
13,67
37,59
53,64
25,19
31,50
6,5
47,68
48,59
56,67
15,59
26,53
57,59
13,64
23,16
32,59
51,52
24,29
36,57
29,24
25,32
19,27
17,20
58,53
38,59
31,7
25,46
31,66
43,53
7,9
35,1
57,57
23,20
33,0
13,69
26,13
49,62
20,13
31,2
6,1
26,1
15,33
39,13
17,59
41,50
45,63
11,5
69,69
19,9
23,15
53,53
57,56
53,57
37,9
23,65
25,33
5,15
43,55
23,55
11,69
33,53
55,31
47,53
29,4
57,60
22,27
65,69
6,11
21,48
15,68
38,9
19,7
23,1
58,63
34,15
43,44
33,52
9,5
11,21
27,29
25,30
22,25
14,11
41,13
29,48
12,3
49,59
25,50
28,69
44,59
61,67
37,55
49,50
20,65
64,67
51,63
41,60
59,54
47,69
1,2
60,57
43,56
23,7
28,63
37,26
26,25
69,63
28,53
11,66
51,58
69,54
23,4
1,1
65,61
30,61
31,23
37,65
48,69
67,56
9,29
17,5
11,19
55,66
58,59
43,49
27,23
57,69
61,69
17,63
16,21
19,58
32,65
33,57
35,2
34,65
38,15
11,61
37,61
33,15
31,67
15,69
12,19
9,10
47,45
13,14
31,8
25,14
15,11
20,17
43,62
63,60
40,61
35,4
23,10
33,13
19,10
19,4
10,21
51,62
19,21
35,13
25,8
63,61
37,67
16,17
44,49
54,69
36,63
13,25
29,23
11,8
21,9
29,64
55,62
14,61
47,63
51,47
49,64
5,13
29,53
21,8
3,15
48,47
19,3
63,59
31,49
47,59
23,63
25,9
13,7
34,61
23,23
9,16
29,31
62,67
51,49
46,49
69,68
55,52
27,13
55,55
21,26
13,8
50,67
37,11
11,15
37,15
57,52
59,56
1,8
65,63
23,17
10,55
51,61
31,53
15,21
35,57
25,49
13,12
11,11
54,53
29,9
17,8
49,53
62,55
27,9
31,61
41,8
10,1
19,57
39,5
41,5
22,69
18,69
21,25
35,12
11,1
17,15
27,18
24,63
13,16
50,53
26,9
57,62
21,14
28,3
11,23
32,61
26,21
25,29
38,63
21,15
31,54
17,12
33,55
8,1
9,11
29,58
57,67
17,24
11,26
47,66
61,57
28,19
25,57
29,55
56,55
33,60
9,13
23,9
25,11
9,12
55,67
9,19
31,15
41,64
16,69
11,68
57,63
27,21
32,55
26,67
65,62
42,69
9,3
42,53
17,67
12,61
57,55
41,63
23,12
19,67
54,59
9,22
31,55
11,25
29,5
19,18
17,36
9,7
45,53
59,45
27,69
19,59
9,8
58,69
35,7
29,21
49,67
1,7
21,6
64,65
31,18
35,58
15,13
23,33
21,17
32,25
25,53
14,19
63,57
52,53
13,4
24,11
1,12
3,4
13,19
60,69
31,1
27,62
41,16
9,20
53,48
2,5
23,25
33,6
47,64
67,65
61,60
12,15
19,11
55,51
14,1
33,61
19,65
21,29
65,55
19,23
32,7
54,55
16,9
31,10
41,54
2,23
34,25
44,51
27,20
53,59
9,21
26,65
10,69
13,13
0,3
11,6
53,61
25,1
35,53
29,16
37,63
18,11
29,14
28,13
19,63
31,31
25,26
47,52
24,19
15,7
37,66
27,2
33,7
26,11
47,55
1,39
35,9
39,1
30,19
12,11
13,20
56,59
56,51
39,9
29,3
47,65
25,21
23,27
23,54
18,9
31,9
65,38
69,66
35,54
3,5
56,69
22,57
30,45
63,47
26,59
29,61
61,58
19,62
34,11
23,13
21,1
24,27
62,61
17,69
43,58
51,66
13,70
28,11
17,25
32,57
49,57
39,6
23,31
17,11
47,54
34,3
37,57
25,13
54,61
49,55
13,15
27,1
44,55
26,29
66,63
43,61
27,61
49,65
13,37
23,69
29,44
52,55
41,57
46,61
16,61
21,61
24,55
23,29
25,5
13,5
63,65
42,63
17,66
17,23
11,64
24,23
10,29
63,41
10,3
51,56
18,5
25,23
29,1
69,61
21,4
21,67
23,6
33,3
41,55
28,31
5,7
9,17
9,25
39,65
24,57
23,22
33,63
16,57
59,63
25,69
21,64
37,3
11,18
41,56
15,57
38,53
19,61
61,53
19,31
31,3
27,60
34,51
39,62
17,68
25,25
21,5
35,14
55,69
52,67
12,67
57,53
19,20
23,21
62,57
31,51
63,63
30,49
11,3
67,68
27,51
57,66
38,69
61,59
27,7
59,61
46,57
62,65
1,11
25,61
27,8
17,29
3,6
43,57
21,11
27,5
53,65
15,17
69,57
40,57
17,31
29,15
33,11
50,65
10,27
16,15
41,51
23,59
27,28
63,51
33,1
1,3
22,61
13,17
28,67
31,70
37,4
63,67
29,56
55,61
32,63
37,5
19,24
32,13
43,63
45,69
41,2
67,48
21,59
25,2
67,61
70,57
17,14
29,47
62,53
26,5
13,63
38,65
59,57
17,64
11,9
41,0
53,55
31,57
55,45
22,15
35,17
55,57
29,66
39,14
28,33
17,17
45,55
45,54
26,49
48,61
32,49
22,59
69,60
59,68
15,3
26,35
16,3
21,2
49,69
22,49
59,65
23,19
33,18
15,61
32,1
34,67
17,65
21,62
21,7
52,63
37,69
19,25
68,59
55,53
9,9
67,67
45,66
1,9
59,55
23,64
35,5
49,60
34,57
29,57
51,57
33,56
41,59
65,47
60,51
63,55
19,6
55,46
14,9
32,23
19,15
31,45
19,30
46,51
38,57
28,21
33,21
7,5
67,70
27,46
33,51
37,8
63,69
65,65
31,11
67,69
20,29
21,12
27,25
7,4
21,57
23,0
62,69
29,17
3,3
34,19
11,7
29,69
19,60
23,18
11,67
69,65
40,5
27,3
64,61
17,26
1,17
2,1
29,49
65,57
11,59
30,13
21,31
68,43
31,16
29,54
2,9
29,50
14,65
23,57
13,3
24,69
9,15
35,61
21,21
9,1
8,13
31,52
29,62
23,67
50,57
43,64
4,9
15,6
4,3
18,57
69,59
53,63
49,47
15,19
15,18
31,46
14,67
20,57
37,60
18,21
54,57
39,63
22,1
31,21
41,1
51,59
18,63
27,57
33,17
61,61
41,3
55,59
64,57
7,13
33,49
50,69
3,7
47,57
30,21
43,65
35,11
39,67
20,23
39,10
3,47
11,45
4,41
7,50
51,15
0,55
65,29
7,38
55,2
68,27
52,39
35,69
16,31
41,40
23,43
30,33
3,46
41,43
1,69
59,35
66,13
58,49
41,53
65,37
7,23
23,44
57,51
25,44
7,22
29,19
27,40
43,45
68,23
37,50
2,67
12,49
56,11
55,3
44,29
15,31
58,29
55,44
43,43
59,1
26,17
15,43
11,39
7,66
2,65
6,7
9,64
65,13
27,53
4,67
55,11
15,62
45,7
51,39
54,23
9,59
59,24
27,37
37,31
61,32
3,39
29,29
47,5
53,19
68,21
33,31
49,45
49,41
35,34
9,69
49,36
45,19
67,35
59,49
2,21
68,17
45,21
59,8
41,27
34,27
32,41
45,15
37,33
6,31
26,57
61,24
46,29
59,10
36,19
69,9
31,43
17,37
8,59
56,43
65,20
15,35
41,69
57,21
49,43
57,37
57,1
67,45
1,53
13,53
49,1
57,13
61,21
31,35
10,43
65,33
62,5
14,29
5,69
49,6
13,61
49,44
62,17
13,52
67,25
65,46
66,5
43,9
37,13
18,45
15,15
1,63
54,37
28,27
51,29
47,25
59,41
47,3
30,27
68,9
19,39
10,51
55,9
48,5
53,23
13,55
32,37
0,59
55,41
53,47
56,1
67,41
65,25
1,57
45,1
14,33
9,63
49,13
15,46
43,68
29,45
40,45
51,45
42,35
61,45
45,3
37,36
8,33
69,19
57,7
41,41
49,51
21,39
1,29
67,21
13,30
0,25
58,45
59,21
59,46
33,19
5,60
53,11
67,9
51,13
39,27
5,49
39,40
49,9
34,23
59,28
10,37
55,32
1,31
55,35
1,15
20,37
61,19
58,1
11,53
59,33
52,41
67,23
5,45
59,6
55,13
65,26
5,65
63,53
24,47
19,45
27,42
59,18
7,53
63,35
61,38
67,40
61,25
39,69
46,43
67,28
38,11
15,40
25,36
17,39
37,51
57,49
69,35
16,43
23,40
50,19
69,27
55,27
23,34
65,11
9,67
26,55
49,8
9,43
13,29
49,16
5,68
55,10
1,40
68,41
9,55
35,16
17,41
63,39
53,20
24,51
53,7
43,51
3,41
33,30
46,35
5,62
47,11
3,45
25,39
2,51
44,21
45,41
49,21
58,31
55,47
13,49
67,24
20,43
11,33
33,39
59,20
45,17
17,21
63,21
5,61
58,25
35,38
27,56
14,37
63,45
7,40
55,7
11,38
66,41
59,40
58,35
1,59
16,39
27,33
40,43
7,21
64,53
9,27
35,50
69,31
47,24
52,11
32,27
33,47
41,19
60,17
9,46
37,37
7,31
51,21
11,41
3,63
17,47
60,7
52,5
41,15
47,9
61,9
70,15
57,9
36,55
5,24
37,45
3,53
61,3
31,65
51,30
59,29
69,41
11,37
59,43
45,45
14,25
39,48
54,19
39,49
9,47
53,29
9,51
18,39
25,51
35,29
55,4
51,38
69,1
51,6
50,29
40,33
39,31
4,49
54,49
69,6
11,29
35,43
45,18
41,22
21,45
61,10
50,11
39,55
44,23
26,33
17,51
57,45
1,43
11,36
64,17
19,17
39,23
64,31
29,25
59,38
7,45
54,29
7,55
66,45
23,39
43,31
3,49
33,29
51,17
55,24
35,30
43,25
41,18
59,7
33,33
35,27
5,44
13,39
47,28
27,30
45,65
57,33
49,7
7,41
59,42
22,43
61,48
17,2
45,49
61,31
21,44
36,21
64,5
39,19
3,56
55,15
64,43
6,55
17,1
61,14
13,42
21,46
47,30
48,31
62,19
37,49
35,32
33,35
49,19
10,61
56,27
37,23
42,33
45,32
63,19
43,7
69,8
39,17
1,67
29,39
61,7
23,45
68,47
31,30
61,49
62,15
3,29
67,51
1,46
59,16
51,1
51,35
66,11
3,64
49,25
53,36
45,43
62,47
49,15
33,41
53,41
39,47
23,52
61,52
37,27
36,17
61,30
63,30
1,50
51,5
41,70
17,57
25,15
66,27
7,61
1,49
31,41
15,67
44,27
12,33
15,53
46,41
7,42
68,25
56,49
64,19
51,36
53,0
69,36
57,41
33,48
28,45
69,43
59,51
8,37
51,37
54,15
23,35
7,39
65,17
35,35
35,51
41,7
4,53
47,2
55,21
38,27
53,16
45,29
53,42
26,39
3,25
51,55
5,16
61,17
24,35
42,49
16,27
1,28
67,11
7,24
12,57
61,20
45,31
43,23
12,41
66,31
3,44
55,42
53,21
52,29
31,33
31,39
33,27
66,51
13,36
47,49
15,25
57,12
68,51
3,27
51,34
38,39
5,70
53,18
47,41
4,29
11,47
53,15
59,17
7,11
55,33
53,5
48,37
61,12
11,30
56,19
52,15
39,24
3,57
63,17
59,25
17,55
5,21
3,59
1,33
39,21
51,25
64,47
35,21
21,55
29,63
42,5
56,25
37,21
49,33
0,63
47,10
7,51
65,53
36,43
5,57
42,25
1,27
59,3
55,34
44,45
64,1
64,15
61,43
15,58
45,35
35,41
51,27
5,17
59,4
65,21
63,9
53,33
9,41
41,29
44,37
47,8
21,49
56,33
57,43
43,35
57,17
44,25
7,47
45,39
33,36
61,37
7,32
18,35
67,19
69,11
59,13
47,13
2,61
13,59
45,4
4,65
65,9
5,33
62,33
59,5
7,16
50,47
29,38
11,27
13,31
67,37
7,35
3,19
19,43
11,57
41,37
3,17
3,12
3,36
45,6
53,45
67,18
9,61
65,34
41,65
27,39
1,51
16,55
59,37
49,61
7,27
21,50
54,9
63,2
46,5
7,62
41,35
19,35
63,22
55,29
2,41
61,23
45,16
13,57
5,67
3,21
67,53
6,51
40,35
39,43
68,45
21,40
21,38
5,59
7,17
16,47
15,45
49,34
5,41
69,39
50,41
49,23
45,33
19,37
51,3
57,5
36,47
3,69
47,33
9,45
53,12
3,65
46,25
35,31
47,26
70,49
28,43
64,39
5,43
53,37
69,32
15,37
3,18
18,41
19,49
63,5
51,7
68,13
45,46
66,15
35,45
67,3
57,6
65,43
37,19
57,35
49,14
69,29
49,29
59,19
47,19
29,40
43,69
8,69
33,28
49,22
27,35
39,15
43,67
57,23
70,25
45,44
31,37
65,19
23,51
12,39
55,19
1,41
37,40
59,9
53,35
3,58
47,39
55,23
67,5
7,19
15,5
30,25
47,17
59,14
62,1
53,1
21,35
3,28
1,54
1,36
67,34
8,27
13,23
59,48
47,47
7,56
57,27
47,14
67,47
11,54
4,33
41,20
52,1
17,50
1,23
51,41
49,24
69,30
67,1
58,33
10,57
37,43
6,41
54,39
69,4
66,49
35,37
67,6
11,44
63,44
35,19
64,27
13,44
6,15
5,63
37,53
9,34
55,49
41,67
67,13
47,27
2,53
38,43
68,3
41,21
61,41
25,38
68,11
22,37
15,27
57,4
47,48
36,29
13,56
61,42
64,9
43,29
63,1
66,1
67,20
43,30
13,47
4,11
48,17
42,19
8,29
34,37
37,18
9,23
7,69
2,35
18,55
63,49
15,39
51,9
3,32
43,47
40,29
49,2
41,66
67,17
43,1
50,25
42,27
53,27
63,15
9,49
1,38
43,11
65,35
45,9
7,29
5,47
54,5
47,12
17,61
2,57
44,33
7,25
1,65
21,47
65,49
9,57
53,3
50,1
55,37
69,7
47,29
65,39
46,3
65,10
13,27
54,45
1,25
48,11
56,47
14,43
14,49
19,51
69,49
49,49
40,25
53,17
17,38
38,21
46,19
0,33
27,17
19,53
53,43
50,39
52,9
49,31
35,33
63,11
63,7
19,47
10,35
37,39
65,22
5,18
46,13
12,53
41,25
65,24
48,27
67,49
31,32
19,5
41,23
38,33
69,25
45,8
1,48
63,37
39,41
31,25
21,33
45,25
5,29
6,35
69,37
47,21
34,45
39,46
3,24
42,47
1,19
56,31
57,3
29,34
52,45
51,4
7,33
4,39
63,6
56,39
39,42
61,28
56,37
35,42
63,40
49,40
50,15
9,31
25,45
23,42
63,36
39,45
8,43
16,35
16,33
13,35
43,33
29,33
49,11
43,13
5,37
57,14
11,35
5,35
51,32
39,22
3,37
43,48
41,47
40,37
68,31
31,29
67,29
9,50
3,51
61,55
7,65
61,29
39,25
43,3
9,65
11,46
61,39
5,23
34,41
66,37
41,39
43,19
37,41
19,41
39,52
5,58
8,45
56,7
14,39
21,36
50,9
3,42
27,43
67,33
17,45
52,49
45,27
43,2
13,28
9,52
62,23
25,27
67,15
1,18
55,25
15,63
61,15
51,11
9,33
5,36
37,47
50,23
8,53
45,37
5,38
65,15
64,51
57,29
57,20
61,1
49,5
39,30
30,41
19,32
9,37
57,36
5,46
57,18
21,43
69,13
67,2
43,37
9,53
50,43
69,14
57,40
67,16
13,26
29,43
65,4
7,58
47,23
21,51
65,5
13,32
33,45
55,8
61,27
25,37
17,42
3,61
1,47
27,6
40,31
36,25
11,60
3,26
41,45
65,41
39,16
57,31
65,31
43,17
65,27
11,55
16,51
5,26
27,16
6,45
63,50
47,40
61,35
69,45
45,5
3,62
50,27
44,39
20,33
7,63
45,23
24,39
49,17
60,35
63,23
49,32
13,33
56,17
10,31
15,49
52,27
64,13
35,49
63,33
9,40
69,33
17,44
17,43
44,3
3,13
6,53
58,39
49,3
17,33
45,11
39,18
59,15
53,31
70,43
10,41
49,20
17,13
15,29
5,55
15,47
34,21
13,43
39,37
43,15
1,21
59,2
7,15
39,51
25,31
44,17
23,37
58,43
7,26
67,43
0,43
44,41
45,47
46,39
42,37
19,33
46,33
17,48
34,69
25,47
5,22
60,33
37,24
15,51
27,41
61,36
55,43
1,61
47,31
8,55
2,29
39,39
52,7
50,13
36,37
69,15
29,37
21,27
63,43
47,7
55,17
59,31
57,15
29,36
3,16
47,46
1,37
61,51
44,11
12,47
3,33
51,67
52,47
25,35
55,5
25,17
50,45
23,48
65,12
42,15
43,6
63,27
1,35
66,7
33,37
2,47
47,37
53,50
3,67
40,27
51,33
7,48
17,35
35,47
59,27
11,65
15,41
21,34
39,54
62,11
3,43
59,23
7,67
7,57
47,51
48,19
49,37
58,9
19,55
17,30
61,44
13,45
25,42
49,4
23,53
7,68
5,53
66,21
57,11
43,8
9,32
3,35
61,47
57,28
5,48
20,49
38,55
37,28
62,27
5,19
65,23
37,32
53,2
61,13
61,40
9,39
60,25
39,33
36,69
11,31
5,39
25,41
13,51
46,15
66,43
52,25
1,20
57,39
53,34
4,55
4,21
23,47
6,29
47,15
68,35
9,66
3,23
44,13
69,47
53,49
9,62
21,32
21,41
57,16
65,45
17,49
63,42
55,1
60,45
61,11
19,52
13,34
62,35
46,23
51,51
59,39
3,55
30,29
35,65
69,55
11,43
7,59
33,32
65,7
23,41
41,33
5,27
18,49
37,44
68,49
63,29
51,43
47,34
3,31
39,35
45,13
7,37
42,31
53,13
6,63
11,49
43,5
37,25
59,11
61,4
36,35
35,25
69,53
65,51
41,17
63,54
21,56
36,49
48,43
53,25
65,1
31,42
51,19
62,49
35,23
70,1
69,23
38,35
42,41
65,32
49,39
52,21
69,21
7,43
59,69
64,29
38,47
51,23
13,41
67,31
43,39
45,10
68,53
7,49
61,8
0,23
17,60
69,5
37,29
33,44
47,43
9,35
45,20
2,33
47,22
55,14
49,35
1,55
1,45
3,11
5,20
6,65
59,12
47,38
5,34
41,38
55,39
3,60
42,11
60,1
2,69
51,18
19,46
37,35
9,48
63,26
49,27
21,37
29,27
7,7
69,34
55,22
14,55
69,38
57,19
59,22
7,20
70,19
55,26
2,31
67,7
41,31
63,31
44,35
52,23
40,51
41,49
31,36
47,35
57,25
33,40
29,35
55,30
69,40
61,33
0,69
63,8
63,46
61,5
11,51
33,43
64,35
43,41
53,32
53,9
67,39
57,22
43,21
63,25
45,0
5,51
69,17
47,1
23,49
28,37
63,3
25,3
69,3
17,9
42,43
32,39
65,3
63,13
39,29
7,60
51,31
42,23
20,41
31,13
41,46
43,27
4,51
53,39
35,39
35,46
59,50
6,17
62,28
64,45
35,20
38,45
42,70
58,48
18,28
29,0
2,17
16,7
48,3
18,62
59,44
39,20
51,46
7,30
36,14
46,62
42,60
49,0
36,65
0,44
37,14
14,70
8,21
28,40
31,40
68,12
38,44
67,66
22,24
40,2
70,0
14,6
15,34
70,44
12,56
52,70
22,32
43,38
12,34
44,4
15,28
60,37
28,35
56,29
61,16
52,0
32,30
4,12
3,30
22,46
37,0
18,34
15,42
8,63
12,1
56,34
20,34
11,70
6,23
66,61
38,34
49,68
6,13
6,38
8,32
46,66
42,65
8,0
36,51
66,20
6,69
34,29
6,22
36,38
53,40
8,14
68,30
34,68
17,34
32,31
0,24
2,30
60,22
6,20
65,44
15,36
57,44
41,62
70,46
40,21
34,42
16,45
30,26
2,68
49,66
56,44
38,46
29,6
28,7
37,42
52,69
37,58
8,60
45,38
15,38
31,60
14,7
28,38
12,9
54,54
30,8
50,54
35,68
2,12
4,48
5,40
62,26
2,58
9,56
18,47
1,16
36,54
48,54
37,46
48,65
48,64
36,60
23,70
34,34
0,49
37,64
2,11
40,10
12,42
20,56
41,10
67,46
46,70
36,39
3,70
24,24
42,24
14,51
55,12
27,26
30,6
30,58
12,60
31,6
68,69
33,38
14,28
36,66
24,28
68,29
14,56
20,48
70,11
44,6
14,3
42,61
3,50
9,42
31,20
30,44
21,70
26,27
18,36
8,28
8,64
22,22
39,66
42,8
30,54
30,30
18,19
26,2
63,16
42,67
69,46
9,36
0,62
22,45
68,28
49,54
0,13
60,70
16,42
8,24
30,43
18,0
16,67
36,10
2,22
54,46
8,11
3,52
28,39
58,70
17,0
34,52
6,36
6,37
46,1
38,20
0,17
34,36
36,31
4,17
52,30
4,36
2,25
12,46
6,26
19,44
52,31
0,66
16,41
58,32
22,0
62,25
5,56
36,68
14,30
36,58
65,18
0,10
60,26
38,7
68,34
30,32
18,30
55,36
4,20
32,40
4,64
5,42
12,45
24,25
58,41
63,48
10,38
60,13
32,69
48,46
15,56
2,14
2,27
40,68
10,40
60,39
60,43
0,47
49,52
20,8
10,68
43,60
35,10
56,70
64,21
38,41
26,48
48,70
0,68
68,50
7,6
16,8
4,70
56,16
49,70
6,50
18,29
24,5
46,38
22,48
12,27
62,22
46,44
0,41
66,48
33,42
44,48
22,52
65,28
70,50
40,4
59,32
12,58
69,24
19,26
38,40
20,1
42,39
6,12
21,0
6,39
14,14
30,35
8,52
48,2
42,6
0,19
11,24
44,62
60,41
18,70
63,32
53,54
64,68
4,27
8,50
0,70
11,20
39,8
63,70
28,42
4,31
61,68
12,43
36,11
19,54
55,70
1,42
59,34
60,12
66,50
29,26
40,8
56,36
2,40
47,60
42,29
64,48
38,16
12,4
12,30
24,43
4,57
58,40
38,66
23,36
11,28
53,46
28,60
11,34
0,11
16,11
19,28
34,35
20,30
6,43
17,40
44,38
14,46
65,30
64,7
34,59
0,48
61,26
6,18
22,21
18,3
66,47
6,49
57,54
20,39
62,21
61,66
63,68
20,70
40,0
38,5
36,36
60,24
54,30
54,40
55,38
2,13
14,66
8,20
15,0
23,30
10,44
11,22
40,46
1,32
52,44
67,12
3,22
66,30
3,38
34,20
70,51
44,40
68,44
64,24
19,40
36,48
18,43
19,48
2,52
57,38
26,40
41,24
25,4
47,44
4,13
24,64
18,61
16,25
26,42
50,68
4,56
0,16
22,35
23,60
51,54
54,63
22,30
45,34
20,40
32,17
1,70
2,38
61,70
11,52
4,61
62,59
11,50
8,70
18,38
60,15
12,26
16,38
50,70
36,18
26,37
32,0
14,64
48,62
60,19
40,66
23,38
35,40
20,6
52,6
60,21
62,32
22,41
32,18
1,22
68,68
52,46
44,10
44,44
33,68
0,36
0,58
69,48
26,44
20,54
26,56
6,27
52,37
6,60
6,70
38,50
17,46
30,34
40,64
6,61
37,48
60,9
18,51
23,24
10,53
9,28
16,4
60,14
10,67
48,0
32,29
28,5
12,62
44,7
38,14
20,4
48,53
57,30
56,12
25,48
56,48
12,6
3,20
41,34
0,65
14,53
60,34
26,28
14,41
8,30
20,51
0,51
54,35
40,70
13,68
34,33
61,50
37,68
16,56
58,52
34,62
36,62
30,15
29,30
42,45
32,42
67,64
16,28
10,16
63,0
70,30
62,36
16,70
62,16
22,12
22,5
9,30
66,57
60,66
29,8
66,4
57,64
24,34
31,4
42,52
50,2
34,46
40,36
0,32
67,36
16,49
30,36
37,10
56,6
64,16
43,32
53,26
12,0
69,20
24,32
67,14
52,68
56,32
26,46
28,22
24,50
60,53
6,48
62,63
59,52
60,49
49,42
26,30
55,48
40,22
27,50
60,44
15,64
36,46
68,20
32,24
28,46
24,18
58,12
60,20
10,4
58,55
6,52
44,70
9,38
58,0
46,18
15,8
46,69
64,6
2,2
28,44
12,18
66,62
34,66
28,36
20,24
68,66
6,33
10,20
10,52
64,11
19,38
29,68
16,60
24,56
0,39
8,25
20,38
16,32
26,34
46,67
32,32
50,66
52,50
19,42
42,18
33,46
58,28
48,68
36,52
21,16
58,36
23,28
60,47
40,50
58,24
22,26
34,44
54,10
26,70
51,44
22,39
2,43
70,60
38,32
30,62
58,8
43,24
30,70
0,52
69,18
6,4
38,62
44,8
57,26
27,70
53,8
66,28
36,23
8,39
54,31
54,64
2,26
8,47
16,66
52,35
65,6
68,37
31,28
9,26
33,4
17,70
23,14
26,20
36,13
8,19
28,50
25,58
58,37
11,12
0,35
48,44
9,44
54,62
7,8
8,65
20,59
68,15
22,68
68,10
33,12
34,60
17,10
28,26
58,50
41,36
57,10
24,61
11,2
14,54
41,30
3,40
44,68
29,12
56,0
30,37
48,12
2,36
49,58
34,28
62,51
62,31
36,41
65,8
70,45
16,52
8,54
12,29
14,27
0,29
68,1
2,8
14,57
11,40
68,0
28,2
25,12
46,53
10,58
31,24
8,26
34,26
50,63
56,42
32,33
56,53
0,28
54,50
50,12
4,34
64,62
54,41
65,36
54,68
18,13
50,8
63,12
60,18
57,8
40,42
48,40
42,58
67,0
2,66
56,2
66,39
56,10
33,50
36,2
5,4
40,40
46,45
12,5
30,51
32,46
14,69
43,40
67,26
68,38
46,47
40,16
24,67
3,54
10,11
4,19
35,6
49,38
43,46
48,16
52,34
12,21
10,45
20,11
60,29
18,26
43,12
63,66
48,48
44,15
2,3
60,67
45,58
30,16
25,68
26,19
26,50
26,54
57,50
4,22
39,4
26,69
70,13
64,28
32,14
41,42
27,24
32,47
30,46
19,36
57,24
68,46
28,61
15,26
43,34
34,18
0,60
42,68
34,30
26,7
44,20
54,34
25,6
14,2
2,37
28,0
54,24
16,14
50,3
44,14
15,60
24,45
18,12
16,22
0,31
40,55
56,28
6,57
38,13
34,58
28,57
62,9
9,58
62,42
4,15
68,56
28,70
54,11
65,64
34,43
58,57
42,28
56,8
16,36
12,17
38,24
50,34
62,64
42,7
42,21
24,48
32,28
18,24
65,58
68,36
37,16
31,58
53,38
0,40
48,6
12,13
50,48
15,24
43,50
13,10
40,62
22,70
51,68
48,4
31,34
22,28
62,39
42,12
32,70
66,2
54,26
16,29
18,46
54,6
54,25
40,7
20,5
64,60
48,9
3,66
45,12
70,20
43,10
20,60
5,54
62,2
51,24
31,38
36,4
10,39
46,8
12,40
53,52
59,36
52,28
5,30
20,3
46,14
12,48
58,15
14,31
60,23
70,54
0,34
32,67
24,21
54,7
6,16
56,23
70,52
62,46
70,27
18,4
30,31
22,56
68,18
19,2
18,52
34,31
58,64
24,1
66,34
10,34
70,67
30,68
44,16
12,68
62,3
46,60
56,61
40,28
46,28
2,39
70,14
52,24
28,6
19,50
48,10
28,18
28,12
34,8
14,42
64,63
64,4
58,13
48,14
28,15
58,44
14,22
48,63
70,62
64,54
25,66
70,3
50,56
68,63
18,37
11,42
13,60
68,48
34,0
19,12
48,36
31,0
40,26
18,31
68,42
34,2
38,54
20,21
15,20
37,52
6,10
60,5
1,26
56,60
39,26
59,0
23,2
0,21
6,40
54,4
60,63
4,40
11,14
24,66
66,8
50,59
48,60
11,32
51,10
2,4
14,16
52,14
0,57
20,58
";
}