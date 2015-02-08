# compiled with BefunCompile v1.0.4 (c) 2015
# execute with at least Python3
def td(a,b):
    return bool(random.getrandbits(1))
def td(a,b):
    return ((0)if(b==0)else(a//b))
def tm(a,b):
    return ((0)if(b==0)else(a%b))
s=[]
def sp():
    global s
    if (len(s) == 0):
        return 0
    return s.pop()
def sa(v):
    global s
    s.append(v)
def sr():
    global s
    if (len(s) == 0):
        return 0
    return s[-1]
x0=32
def _0():
    return (18)if(sp()!=0)else(3)
def _1():
    return (15)if(sp()!=0)else(7)
def _2():
    global x0
    x0=9990
    sa(0)
    sa(0)
    sa(999)
    sa((9)+(x0))
    sa(99)
    sa(99)
    return 0
def _3():
    global x0
    x0=0
    sp()
    sa(sr())
    sa(sr())
    return 19
def _4():
    global x0
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*(2));
    x0=sp()
    return 19
def _5():
    sa(sr())
    print(sp(),end="",flush=True)
    print(chr(10),end="",flush=True)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 21
def _6():
    global x0
    x0=990
    sa(999)
    sa((9)+(x0))
    sa(99)
    sa(99)
    return 1
def _7():
    global x0
    x0=0
    sp()
    sa(sr())
    sa(sr())
    return 22
def _8():
    global x0
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*(2));
    x0=sp()
    return 22
def _9():
    sa(sr())
    print(sp(),end="",flush=True)
    print(chr(10),end="",flush=True)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 24
def _10():
    global x0
    global x0
    sa(sr())
    sa(sr())
    sa(td(sp(),10))
    sa(sp()*(10));
    x0=sp()
    sa(sr())
    sa(tm(sp(),10))
    sa(sp()+(x0));
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))
    sa(sr())
    return 1
def _11():
    sa(61)
    print(chr(32),end="",flush=True)
    print(chr(sp()),end="",flush=True)
    return 25
def _12():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+sp());
    return 25
def _13():
    sa(sp()+sp());
    print(sp(),end="",flush=True)
    return 26
def _14():
    sp()
    return 24
def _15():
    global x0
    global x0
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*(10));
    x0=sp()
    sa(sr())
    sa(tm(sp(),10))
    sa(sp()+(x0));
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))
    sa(sr())
    return 1
def _16():
    global x0
    global x0
    sa(sr())
    sa(sr())
    sa(sp()*(10));
    x0=sp()
    sa(sr())
    sa(tm(sp(),10))
    sa(sp()+(x0));
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))
    sa(sr())
    return 0
def _17():
    sp()
    return 21
def _18():
    global x0
    global x0
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*(10));
    x0=sp()
    sa(sr())
    sa(tm(sp(),10))
    sa(sp()+(x0));
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))
    sa(sr())
    return 0
def _19():
    global x0
    sa(sr())
    sa(tm(sp(),2))
    sa(sp()+(x0));
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),2))
    sa(sr())
    return (4)if(sp()!=0)else(20)
def _20():
    sp()
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return (5)if(sp()!=0)else(17)
def _21():
    sa(sp()-(1));
    sa(sr())
    return (16)if(sp()!=0)else(6)
def _22():
    global x0
    sa(sr())
    sa(tm(sp(),2))
    sa(sp()+(x0));
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),2))
    sa(sr())
    return (8)if(sp()!=0)else(23)
def _23():
    sp()
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return (9)if(sp()!=0)else(14)
def _24():
    sa(sp()-(1));
    sa(sr())
    return (10)if(sp()!=0)else(11)
def _25():
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return (12)if(sp()!=0)else(13)
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25]
c=2
while c<26:
    c=m[c]()