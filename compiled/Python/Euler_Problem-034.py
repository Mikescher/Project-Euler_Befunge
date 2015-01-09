# compiled with BefunCompile v1.0.1 (c) 2015
# execute with at least Python3
from random import randint
g=[[118,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32],[62,49,58,48,48,112,49,42,58,49,48,112,50,42,58,50,48,112,51,42,58,51,48,112,52,42,58,52,48,112,53,42,58,118,32,32,32,32,32,32,32,32,32,32,32],[118,112,49,49,48,36,112,48,57,58,42,57,112,48,56,58,42,56,112,48,55,58,42,55,112,48,54,58,42,54,112,48,53,60,32,32,32,32,32,32,32,32,32,32,32],[32,32,32,32,32,32,118,95,118,35,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,58,45,49,60,112,49,49,32,60],[62,57,48,103,55,42,62,58,58,48,92,62,58,53,53,43,37,48,103,92,53,53,43,47,58,35,118,95,62,43,35,60,92,58,35,60,95,43,45,124,32,32,32,32,43],[32,32,32,32,62,51,45,46,36,64,32,124,58,47,43,53,53,92,103,48,37,43,53,53,58,32,60,32,32,32,32,32,32,32,32,32,32,32,32,62,58,49,49,103,94],[32,32,32,32,94,103,49,49,60,32,32,62,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,94,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32]];
def gr(x,y):
    if(x>=0 and y>=0 and x<45 and y<7):
        return g[y][x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<45 and y<7):
        g[y][x]=v;
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