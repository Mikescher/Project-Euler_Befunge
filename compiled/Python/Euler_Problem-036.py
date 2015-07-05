#!/usr/bin/env python3
# compiled with BefunCompile v1.0.6 (c) 2015
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
x0=9990
def _0():
    sa(0)
    sa(0)
    sa(999)
    sa(9+x0)
    sa(99)
    return 1
def _1():
    global x0
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*10);
    x0=sp()
    sa((tm(sr(),10))+x0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))
    sa(sr())
    return 2
def _2():
    return (1)if(sp()!=0)else(3)
def _3():
    global x0
    x0=0
    sp()
    sa(sr())
    sa(sr())
    return 4
def _4():
    sa((tm(sr(),2))+x0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),2))
    sa(sr())
    return (25)if(sp()!=0)else(5)
def _5():
    sp()
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return (24)if(sp()!=0)else(6)
def _6():
    sp()
    return 7
def _7():
    sa(sp()-1);
    sa(sr())
    return (8)if(sp()!=0)else(9)
def _8():
    global x0
    sa(sr())
    sa(sr()*10)
    x0=sp()
    sa((tm(sr(),10))+x0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))
    sa(sr())
    return 2
def _9():
    global x0
    x0=990
    sa(999)
    sa(9+x0)
    sa(99)
    return 10
def _10():
    global x0
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*10);
    x0=sp()
    sa((tm(sr(),10))+x0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))
    sa(sr())
    return 11
def _11():
    return (10)if(sp()!=0)else(12)
def _12():
    global x0
    x0=0
    sp()
    sa(sr())
    sa(sr())
    return 13
def _13():
    sa((tm(sr(),2))+x0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),2))
    sa(sr())
    return (23)if(sp()!=0)else(14)
def _14():
    sp()
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return (22)if(sp()!=0)else(15)
def _15():
    sp()
    return 16
def _16():
    sa(sp()-1);
    sa(sr())
    return (21)if(sp()!=0)else(17)
def _17():
    sa(61)
    print(chr(32),end="",flush=True)
    print(chr(sp()),end="",flush=True)
    return 18
def _18():
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return (20)if(sp()!=0)else(19)
def _19():
    sa(sp()+sp());
    print(sp(),end="",flush=True)
    return 26
def _20():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+sp());
    return 18
def _21():
    global x0
    sa(sr())
    sa((td(sr(),10))*10)
    x0=sp()
    sa((tm(sr(),10))+x0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))
    sa(sr())
    return 11
def _22():
    sa(sr())
    print(sp(),end="",flush=True)
    print(chr(10),end="",flush=True)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 16
def _23():
    global x0
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*2);
    x0=sp()
    return 13
def _24():
    sa(sr())
    print(sp(),end="",flush=True)
    print(chr(10),end="",flush=True)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 7
def _25():
    global x0
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*2);
    x0=sp()
    return 4
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25]
c=0
while c<26:
    c=m[c]()