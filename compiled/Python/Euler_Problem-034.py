# compiled with BefunCompile v1.0.3 (c) 2015
# execute with at least Python3
from random import randint
import gzip, base64
_g="AR+LCAAAAAAABACVjr0OgzAMhF8lUsriiGID4ecURX2QCMasnjLx8A2dWqoO9XLW2b7PxfxRUcCsQhDWntCzDoSBdSSMrJ5Q3paLivBNeQWtygtoUZ5Bs/IEmpR9+Move7G/6Wgl1EwT4sp5pghwivDeNZxTlQ627NHZkGDD7trjPHKvv4f2fnuYA53zPmVuqsB88CNE8nZ2Wxapo3jFb1fjCcDxR0M7AQAA"
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<45 and y<7):
        return g[y*45 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<45 and y<7):
        g[y*45 + x]=v;
def rd():
    return bool(random.getrandbits(1))
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
    return (13)if(sp()!=0)else(6)
def _1():
    return (14)if(sp()!=0)else(6)
def _2():
    return (7)if(sp()!=0)else(8)
def _3():
    return (10)if(sp()!=0)else(9)
def _4():
    return (11)if(sp()!=0)else(12)
def _5():
    gw(0,0,1)
    gw(1,0,1)
    gw(2,0,2)
    gw(3,0,6)
    gw(4,0,24)
    gw(5,0,120)
    gw(6,0,720)
    gw(7,0,5040)
    gw(8,0,40320)
    gw(9,0,362880)
    gw(1,1,0)
    sa((gr(9,0))*(7))
    sa((gr(9,0))*(7))
    sa(0)
    sa(gr(tm((gr(9,0))*(7),10),0))
    sa(td((gr(9,0))*(7),10))
    sa(td((gr(9,0))*(7),10))
    return 0
def _6():
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return 2
def _7():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 6
def _8():
    sa(sp()+sp());
    v0=sp()
    sa(sp()-v0)
    return 3
def _9():
    sa(sr())
    sa(gr(1,1))
    sa(sp()+sp());
    gw(1,1,sp())
    return 10
def _10():
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return 4
def _11():
    sa(sr())
    sa(sr())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(0)
    v0=sp()
    sa(gr(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    return 0
def _12():
    sa(sr())
    sp()
    print((gr(1,1))-(3),end="",flush=True)
    sp()
    return 15
def _13():
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(0)
    v0=sp()
    sa(gr(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    return 1
def _14():
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(0)
    v0=sp()
    sa(gr(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(sr())
    return 0
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14]
c=5
while c<15:
    c=m[c]()