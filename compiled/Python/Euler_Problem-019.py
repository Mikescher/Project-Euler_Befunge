# compiled with BefunCompile v1.0.3 (c) 2015
# execute with at least Python3
from random import randint
import gzip, base64
_g="AR+LCAAAAAAABACtkcFqxCAQhl8lNU0pimXmNyREgvRBQnopzNWTpzx8xyULuwS2bNoRRceZz3/GEihAx2VpzlsJ/C+c4Q+5t5ZgU4wkhozvR+sWyjGWU6gtes68ODv2XnHCzfw8pDSvJ7KOlkDIzDqBbPBmLLuATBPyU9UVkGMBZUxOML04ryfuRnXNqd2DqG1K3e/K01FNSSpE2KmgAOm7u9vtGsVNSoAsUmO93w6cX2pWtPk2nebRWsW0V64+q9zITpsxDO4huXS2V4ogaIHrF68q0Du25h0XZ0aoHQlK5EdfddOFNVWKuibIx+fuuwuefwDyEoFQYAMAAA=="
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<72 and y<12):
        return g[y*72 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<72 and y<12):
        g[y*72 + x]=v;
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
    return (21)if(sp()!=0)else(8)
def _1():
    return (10)if(sp()!=0)else(16)
def _2():
    return (11)if(sp()!=0)else(14)
def _3():
    return (13)if(sp()!=0)else(12)
def _4():
    return (11)if(sp()!=0)else(15)
def _5():
    return (17)if(sp()!=0)else(18)
def _6():
    return (19)if(sp()!=0)else(20)
def _7():
    gw(12,0,((gr(12,0))-(48))+(28))
    gw(12,1,((gr(12,1))-(48))+(28))
    sa(11)
    sa(11)
    return 0
def _8():
    gw(0,2,2)
    gw(1,2,1)
    gw(2,2,1)
    gw(3,2,1901)
    gw(9,2,0)
    gw(9,2,((0)if(((tm(gr(0,2),7))+((gr(1,2))-(1)))!=0)else(1))+(gr(9,2)))
    gw(0,2,(gr(0,2))+(1))
    gw(1,2,(gr(1,2))+(1))
    sp()
    return 9
def _9():
    sa(tm(gr(3,2),4))
    return 1
def _10():
    sa((gr(gr(2,2),0))-((gr(1,2))-(1)))
    return 2
def _11():
    sa((gr(3,2))-(2001))
    return 3
def _12():
    print(gr(9,2),end="",flush=True)
    return 22
def _13():
    gw(9,2,((0)if(((tm(gr(0,2),7))+((gr(1,2))-(1)))!=0)else(1))+(gr(9,2)))
    gw(0,2,(gr(0,2))+(1))
    gw(1,2,(gr(1,2))+(1))
    return 9
def _14():
    gw(1,2,1)
    sa(gr(2,2))
    gw(2,2,(gr(2,2))+(1))
    sa(12)
    v0=sp()
    sa(sp()-v0)
    return 4
def _15():
    gw(2,2,1)
    gw(3,2,(gr(3,2))+(1))
    return 11
def _16():
    sa(tm(gr(3,2),100))
    return 5
def _17():
    sa((gr(gr(2,2),1))-((gr(1,2))-(1)))
    return 2
def _18():
    sa(tm(gr(3,2),400))
    return 6
def _19():
    sa((gr(gr(2,2),0))-((gr(1,2))-(1)))
    return 2
def _20():
    sa((gr(gr(2,2),1))-((gr(1,2))-(1)))
    return 2
def _21():
    sa(sr())
    sa(sr())
    sa(0)
    v0=sp()
    sa(gr(sp(),v0))
    sa(48)
    v0=sp()
    sa(sp()-v0)
    sa(28)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(0)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr())
    sa(sr())
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa(48)
    v0=sp()
    sa(sp()-v0)
    sa(28)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return 0
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21]
c=7
while c<22:
    c=m[c]()