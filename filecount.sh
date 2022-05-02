cloc InventoryManagerDemo.BLL \
  --by-file ./ \
  --by-file-by-lang \
  --ignore-whitespace \
  --exclude-dir=.gdn,.git,.github,.vs,InventoryManagerDemo.Test,netcoreapp2.1,netcoreapp3.1 \
  --exclude-list-file=.gitignore,aws-lambda-tools-defaults.json,launchSettings.json \
  --exclude-ext=cache,cmd,csproj,deps.json,dgspec.json,dll,editorconfig,g.props,g.targets,json,md,pdb,sln,runtimeconfig.json,runtimeconfig.dev.json,sh,template,txt