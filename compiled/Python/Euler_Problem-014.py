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
x0=118
x1=32
def _0():
    return (2)if(sp()!=0)else(8)
def _1():
    global x0
    x0=0
    sa(4)
    sa(1)
    sa(4)
    sa(0)
    return 0
def _2():
    sa(sp()*(3));
    sa(sp()+(1));
    return 9
def _3():
    sa(td(sp(),1))
    sa(sr())
    sa(tm(sp(),2))
    return 0
def _4():
    global x0
    global x1
    x0=sp()
    sa(sr())
    x1=sp()
    return 11
def _5():
    sa(sp()+(1));
    sa(sr())
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(tm(sp(),2))
    return 0
def _6():
    global x1
    global x0
    print(x1,end="",flush=True)
    sa(x0)
    sa(58)
    print(chr(32),end="",flush=True)
    print(chr(sp()),end="",flush=True)
    print(sp(),end="",flush=True)
    return 12
def _7():
    sp()
    return 11
def _8():
    sa(td(sp(),2))
    return 9
def _9():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+(1));
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(sp()-(1));
    return (3)if(sp()!=0)else(10)
def _10():
    global x0
    sp()
    sa(sr())
    sa(x0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return (7)if(sp()!=0)else(4)
def _11():
    sa(sr())
    sa((1)if(sp()>(1000000))else(0))
    sa((0)if(sp()!=0)else(1))
    return (5)if(sp()!=0)else(6)
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11]
c=1
while c<12:
    c=m[c]()