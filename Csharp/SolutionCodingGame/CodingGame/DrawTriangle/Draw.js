const n = parseInt(readline());

let i = n;

for (i; i > 0; i--) {
    print('*'.repeat(i));
}
for (i = i + 1; i <= n; i++) {
    print('*'.repeat(i));
}