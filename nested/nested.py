from functools import reduce 
from operator import getitem
def test(d, selectors):
  return reduce(getitem, selectors, d) 
users = {
  'shankar ': {
    'name': {
      'first': 'shankar ',
      'last': 'ajmeera' 
    },
    'postIds': [1, 2, 3, 4, 5]
  }
}
print(test(users, ['shankar ', 'name', 'first']))
print(test(users, ['shankar ', 'postIds', 3]))
