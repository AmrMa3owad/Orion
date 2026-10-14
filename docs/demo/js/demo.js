// Demo sample data and render functions
const demoData = {
  orphanages: 4,
  products: [
    { id: 1, name: 'Beaded Bracelet', price: 12.5, image: 'https://images.unsplash.com/photo-1511452885604-1a7a6a1b9b92?w=800&q=60&auto=format&fit=crop'},
    { id: 2, name: 'Crochet Keychain', price: 7.0, image: 'https://images.unsplash.com/photo-1519677100203-a0e668c92439?w=800&q=60&auto=format&fit=crop'},
    { id: 3, name: 'Resin Pendant', price: 15.0, image: 'https://images.unsplash.com/photo-1533779342107-4f4e2e5b96c7?w=800&q=60&auto=format&fit=crop'}
  ],
  freelancers: [
    { id: 1, firstName: 'Amina', skill: 'Beads', photo: 'https://images.unsplash.com/photo-1545996124-1e7b8d4a30a1?w=800&q=60&auto=format&fit=crop', bio: 'Loves making bracelets and small accessories.'},
    { id: 2, firstName: 'Karim', skill: 'Crochet', photo: 'https://images.unsplash.com/photo-1524504388940-b1c1722653e1?w=800&q=60&auto=format&fit=crop', bio: 'Creates colorful crochet keychains and toys.'}
  ]
};

function renderHome(){
  document.getElementById('stat-orphanages').textContent = demoData.orphanages;
  document.getElementById('stat-products').textContent = demoData.products.length;
  document.getElementById('stat-freelancers').textContent = demoData.freelancers.length;

  const container = document.getElementById('freelancer-list');
  container.innerHTML = '';
  demoData.freelancers.forEach(f => {
    const el = document.createElement('div');
    el.className = 'card';
    el.innerHTML = `<img src="${f.photo}" alt="${f.firstName}" loading="lazy" /><h3>${f.firstName}</h3><p>${f.skill}</p><p><a href="/Orion/docs/demo/profile.html?id=${f.id}">View profile</a></p>`;
    container.appendChild(el);
  });
}

function renderProducts(){
  const grid = document.getElementById('product-grid');
  grid.innerHTML = '';
  demoData.products.forEach(p => {
    const box = document.createElement('div');
    box.className = 'product-box';
    box.innerHTML = `<a href="/Orion/docs/demo/details.html?id=${p.id}"><img src="${p.image}" alt="${p.name}" loading="lazy"></a><h4>${p.name}</h4><div>$${p.price}</div>`;
    grid.appendChild(box);
  });
}

function getQueryParam(name){
  const url = new URL(window.location.href);
  return url.searchParams.get(name);
}

function renderDetails(){
  const id = parseInt(getQueryParam('id') || '1', 10);
  const p = demoData.products.find(x => x.id === id) || demoData.products[0];
  const container = document.getElementById('detail-container');
  container.innerHTML = `<div class="detail"><div><img src="${p.image}" alt="${p.name}"/></div><div><h2>${p.name}</h2><p>Price: $${p.price}</p><p>Lorem ipsum dolor sit amet, handmade product description to showcase the UI.</p><p><a href="/Orion/docs/demo/products.html">Back to products</a></p></div></div>`;
}

function renderProfile(){
  const id = parseInt(getQueryParam('id') || '1', 10);
  const f = demoData.freelancers.find(x => x.id === id) || demoData.freelancers[0];
  const container = document.getElementById('profile-container');
  container.innerHTML = `<div class="card"><img src="${f.photo}" alt="${f.firstName}"/><h2>${f.firstName}</h2><h4>${f.skill}</h4><p>${f.bio}</p><p><a href="/Orion/docs/demo/index.html">Back to home</a></p></div>`;
}
