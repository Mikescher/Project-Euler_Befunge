# compiled with BefunCompile v1.0.4 (c) 2015
# execute with at least Python3
import gzip, base64
_g = ("AR+LCAAAAAAABADtj70OwjAMhF/FBLo0CnVKc6CoqlhZmJhhzOqpE7w7ThH/CCFYuSGRfbY+X8/fq//vfipPP6gjwyZmMQt74Vp4JtwIB6GeqKpotV5tXu6qLWjKhTkY"
  + "AZeCOkLgo2kNUdurCecT8LjX3uAZyTtA7ga4I2gfqTh9VdIjnc3N/YmbNRm/C9Y+t6YZ2CDF0Xi7I+8axV74PNdn4A7uGXLWMnOR01i9pbAhRJswL2unpR4IT+oVaRh5"
  + "we4uWSQEW2UYrtG375LQEQVMzVNIAwAA")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<60 and y<14):
        return g[y*60 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<60 and y<14):
        g[y*60 + x]=v;
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
    gw(0,0,48)
    gw(0,1,48)
    gw(0,2,48)
    gw(0,3,48)
    gw(0,4,48)
    gw(0,5,48)
    gw(1,6,60)
    gw(2,6,6)
    gw(0,6,360)
    gw(4,6,1000)
    return 1
def _1():
    sa(gr(4,6))
    return (5)if((0)if((gr(4,6))!=0)else(1))else(2)
def _2():
    sa(1)
    v0=sp()
    sa(sp()-v0)
    gw(4,6,sp())
    gw(6,6,(gr(0,6))-(1))
    gw(7,6,0)
    return 3
def _3():
    return (1)if((0)if((gr(6,6))!=0)else(1))else(4)
def _4():
    sa((((gr(tm(gr(6,6),gr(1,6)),td(gr(6,6),gr(1,6))))-(48))*(2))+(gr(7,6)))
    gw(tm(gr(6,6),gr(1,6)),td(gr(6,6),gr(1,6)),(tm((((gr(tm(gr(6,6),gr(1,6)),td(gr(6,6),gr(1,6))))-(48))*(2))+(gr(7,6)),10))+(48))
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    gw(7,6,sp())
    gw(6,6,(gr(6,6))-(1))
    return 3
def _5():
    gw(6,6,(gr(0,6))-(1))
    sp()
    sa((0)+((gr(tm(gr(6,6),gr(1,6)),td(gr(6,6),gr(1,6))))-(48)))
    return 6
def _6():
    return (8)if(gr(6,6))else(7)
def _7():
    print(sp(),end="",flush=True)
    return 9
def _8():
    gw(6,6,(gr(6,6))-(1))
    sa((gr(tm(gr(6,6),gr(1,6)),td(gr(6,6),gr(1,6))))-(48))
    sa(sp()+sp());
    return 6
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8]
c=0
while c<9:
    c=m[c]()