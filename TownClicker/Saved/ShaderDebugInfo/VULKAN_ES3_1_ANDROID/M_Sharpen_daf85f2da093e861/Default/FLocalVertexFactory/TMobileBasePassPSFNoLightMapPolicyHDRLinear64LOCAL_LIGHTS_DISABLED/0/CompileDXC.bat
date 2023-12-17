@ECHO OFF
SET DXC="F:\UE_5.3\Engine\Binaries\ThirdParty\ShaderConductor\Win64\dxc.exe"
SET SPIRVCROSS="spirv-cross.exe"
IF NOT EXIST %DXC% (
	ECHO Couldn't find dxc.exe under "F:\UE_5.3\Engine\Binaries\ThirdParty\ShaderConductor\Win64"
	GOTO :END
)
ECHO Compiling with DXC...
%DXC% -HV 2018 -T ps_6_2 -E Main -spirv -fspv-target-env=vulkan1.1 -Fo MobileBasePassPixelShader.DXC.spv MobileBasePassPixelShader.usf
WHERE %SPIRVCROSS%
IF %ERRORLEVEL% NEQ 0 (
	ECHO spirv-cross.exe not found in Path environment variable, please build it from source https://github.com/KhronosGroup/SPIRV-Cross
	GOTO :END
)
ECHO Translating SPIRV back to glsl...
%SPIRVCROSS% --vulkan-semantics --output MobileBasePassPixelShader.SPV.glsl MobileBasePassPixelShader.DXC.spv
:END
PAUSE
