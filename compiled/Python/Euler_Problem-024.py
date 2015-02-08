# compiled with BefunCompile v1.0.4 (c) 2015
# execute with at least Python3
import gzip, base64
_g = ("AR+LCAAAAAAABACdUDGOAyEM/AqBrVgRMbtc7oKQdQ+xNlesREuFUvD4mCVpI+WmsEdG4xlcPZY1fF2+f67qY5De911bi/q5VtWC5VoAl/4hfgWoNKxHTU/SN9LgxHBc"
  + "j2lBmJEREi3IEXOj1plninDRbLeJLB89NhGuKApBirAckC2Q/07t6Ty9CTVhk9acvmuVfeTESOI7cnX89nTvUI93wsw9CsZwk4M5+cDSj2Y7CxlrBs7Fs3ix016LHxmn"
  + "DJSZlBHDbYgfFCr43OgBAAA=")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<61 and y<8):
        return g[y*61 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<61 and y<8):
        g[y*61 + x]=v;
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
def _0():
    return (6)if(sp()!=0)else(18)
def _1():
    return (7)if(sp()!=0)else(8)
def _2():
    return (9)if(sp()!=0)else(21)
def _3():
    return (16)if(sp()!=0)else(19)
def _4():
    gw(1,1,999999)
    gw(2,1,9)
    return 20
def _5():
    sp()
    return 23
def _6():
    sa(0)
    sa(gr(2,1))
    sa((gr(2,1))-(1))
    sa((gr(2,1))-(1))
    return 1
def _7():
    sa(sr())
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return 1
def _8():
    sp()
    return 9
def _9():
    sa(sp()*sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return 2
def _10():
    gw(3,1,1)
    gw(4,1,1)
    sp()
    return 22
def _11():
    gw(4,1,(gr(4,1))+(1))
    return 22
def _12():
    sa(gr(4,1))
    return 13
def _13():
    sa(1)
    sa((gr(1,0))-(120))
    return 3
def _14():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(0)
    v0=sp()
    sa(gr(sp(),v0))
    sa(120)
    v0=sp()
    sa(sp()-v0)
    return 3
def _15():
    sp()
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa(0)
    v0=sp()
    sa(gr(sp(),v0))
    sa(48)
    v0=sp()
    sa(sp()-v0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(120)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(0)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    gw(1,1,(gr(1,1))-((gr(3,1))*((gr(4,1))-(1))))
    gw(2,1,(gr(2,1))-(1))
    print(sp(),end="",flush=True)
    return 20
def _16():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    sa(sp()-v0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 19
def _17():
    gw(3,1,sp())
    gw(4,1,1)
    return 22
def _18():
    sa(1)
    return 13
def _19():
    sa(1)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return (14)if(sp()!=0)else(15)
def _20():
    sa(gr(2,1))
    return (0)if((gr(2,1))+(1))else(5)
def _21():
    sp()
    sa(sr())
    return (17)if(sp()!=0)else(10)
def _22():
    sa((0)if(((1)if(((gr(3,1))*(gr(4,1)))>(gr(1,1)))else(0))!=0)else(1))
    return (11)if(sp()!=0)else(12)
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22]
c=4
while c<23:
    c=m[c]()