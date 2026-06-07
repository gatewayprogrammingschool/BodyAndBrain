# links-to-html.lua
local function starts_with(text, prefix)
  return string.sub(text, 1, string.len(prefix)) == prefix
end

local function slugify_fragment(fragment)
  local slug = string.lower(fragment)
  slug = string.gsub(slug, "[^%w%s%-]", "")
  slug = string.gsub(slug, "%s+", "-")
  slug = string.gsub(slug, "^-+", "")
  slug = string.gsub(slug, "-+$", "")
  return slug
end

function Link(el)
  el.target = string.gsub(el.target, "%.md", ".html")
  if starts_with(el.target, "#") then
    el.target = "#" .. slugify_fragment(string.sub(el.target, 2))
  end
  return el
end
