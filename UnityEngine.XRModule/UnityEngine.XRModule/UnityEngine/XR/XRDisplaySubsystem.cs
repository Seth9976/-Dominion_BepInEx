using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.XR
{
	// Token: 0x02000010 RID: 16
	public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor>
	{
		// Token: 0x060000CE RID: 206 RVA: 0x00004874 File Offset: 0x00002A74
		// Note: this type is marked as 'beforefieldinit'.
		static XRDisplaySubsystem()
		{
			Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "XRDisplaySubsystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr);
			XRDisplaySubsystem.NativeFieldInfoPtr_displayFocusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, "displayFocusChanged");
			XRDisplaySubsystem.NativeMethodInfoPtr_InvokeDisplayFocusChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663330);
			XRDisplaySubsystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663331);
			XRDisplaySubsystem.get_displayOpaqueDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.get_displayOpaqueDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_displayOpaque");
			XRDisplaySubsystem.get_contentProtectionEnabledDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.get_contentProtectionEnabledDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_contentProtectionEnabled");
			XRDisplaySubsystem.set_contentProtectionEnabledDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.set_contentProtectionEnabledDelegate>("UnityEngine.XR.XRDisplaySubsystem::set_contentProtectionEnabled");
			XRDisplaySubsystem.get_scaleOfAllViewportsDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.get_scaleOfAllViewportsDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_scaleOfAllViewports");
			XRDisplaySubsystem.set_scaleOfAllViewportsDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.set_scaleOfAllViewportsDelegate>("UnityEngine.XR.XRDisplaySubsystem::set_scaleOfAllViewports");
			XRDisplaySubsystem.get_scaleOfAllRenderTargetsDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.get_scaleOfAllRenderTargetsDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_scaleOfAllRenderTargets");
			XRDisplaySubsystem.set_scaleOfAllRenderTargetsDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.set_scaleOfAllRenderTargetsDelegate>("UnityEngine.XR.XRDisplaySubsystem::set_scaleOfAllRenderTargets");
			XRDisplaySubsystem.get_zNearDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.get_zNearDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_zNear");
			XRDisplaySubsystem.set_zNearDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.set_zNearDelegate>("UnityEngine.XR.XRDisplaySubsystem::set_zNear");
			XRDisplaySubsystem.get_zFarDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.get_zFarDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_zFar");
			XRDisplaySubsystem.set_zFarDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.set_zFarDelegate>("UnityEngine.XR.XRDisplaySubsystem::set_zFar");
			XRDisplaySubsystem.get_sRGBDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.get_sRGBDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_sRGB");
			XRDisplaySubsystem.set_sRGBDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.set_sRGBDelegate>("UnityEngine.XR.XRDisplaySubsystem::set_sRGB");
			XRDisplaySubsystem.MarkTransformLateLatchedDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.MarkTransformLateLatchedDelegate>("UnityEngine.XR.XRDisplaySubsystem::MarkTransformLateLatched");
			XRDisplaySubsystem.get_textureLayoutDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.get_textureLayoutDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_textureLayout");
			XRDisplaySubsystem.set_textureLayoutDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.set_textureLayoutDelegate>("UnityEngine.XR.XRDisplaySubsystem::set_textureLayout");
			XRDisplaySubsystem.get_supportedTextureLayoutsDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.get_supportedTextureLayoutsDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_supportedTextureLayouts");
			XRDisplaySubsystem.get_reprojectionModeDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.get_reprojectionModeDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_reprojectionMode");
			XRDisplaySubsystem.set_reprojectionModeDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.set_reprojectionModeDelegate>("UnityEngine.XR.XRDisplaySubsystem::set_reprojectionMode");
			XRDisplaySubsystem.SetMSAALevelDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.SetMSAALevelDelegate>("UnityEngine.XR.XRDisplaySubsystem::SetMSAALevel");
			XRDisplaySubsystem.get_disableLegacyRendererDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.get_disableLegacyRendererDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_disableLegacyRenderer");
			XRDisplaySubsystem.set_disableLegacyRendererDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.set_disableLegacyRendererDelegate>("UnityEngine.XR.XRDisplaySubsystem::set_disableLegacyRenderer");
			XRDisplaySubsystem.GetRenderPassCountDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.GetRenderPassCountDelegate>("UnityEngine.XR.XRDisplaySubsystem::GetRenderPassCount");
			XRDisplaySubsystem.Internal_TryGetRenderPassDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.Internal_TryGetRenderPassDelegate>("UnityEngine.XR.XRDisplaySubsystem::Internal_TryGetRenderPass");
			XRDisplaySubsystem.TryGetAppGPUTimeLastFrameDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.TryGetAppGPUTimeLastFrameDelegate>("UnityEngine.XR.XRDisplaySubsystem::TryGetAppGPUTimeLastFrame");
			XRDisplaySubsystem.TryGetCompositorGPUTimeLastFrameDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.TryGetCompositorGPUTimeLastFrameDelegate>("UnityEngine.XR.XRDisplaySubsystem::TryGetCompositorGPUTimeLastFrame");
			XRDisplaySubsystem.TryGetDroppedFrameCountDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.TryGetDroppedFrameCountDelegate>("UnityEngine.XR.XRDisplaySubsystem::TryGetDroppedFrameCount");
			XRDisplaySubsystem.TryGetFramePresentCountDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.TryGetFramePresentCountDelegate>("UnityEngine.XR.XRDisplaySubsystem::TryGetFramePresentCount");
			XRDisplaySubsystem.TryGetDisplayRefreshRateDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.TryGetDisplayRefreshRateDelegate>("UnityEngine.XR.XRDisplaySubsystem::TryGetDisplayRefreshRate");
			XRDisplaySubsystem.TryGetMotionToPhotonDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.TryGetMotionToPhotonDelegate>("UnityEngine.XR.XRDisplaySubsystem::TryGetMotionToPhoton");
			XRDisplaySubsystem.GetRenderTextureForRenderPassDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.GetRenderTextureForRenderPassDelegate>("UnityEngine.XR.XRDisplaySubsystem::GetRenderTextureForRenderPass");
			XRDisplaySubsystem.GetPreferredMirrorBlitModeDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.GetPreferredMirrorBlitModeDelegate>("UnityEngine.XR.XRDisplaySubsystem::GetPreferredMirrorBlitMode");
			XRDisplaySubsystem.SetPreferredMirrorBlitModeDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.SetPreferredMirrorBlitModeDelegate>("UnityEngine.XR.XRDisplaySubsystem::SetPreferredMirrorBlitMode");
			XRDisplaySubsystem.GetMirrorViewBlitDescDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.GetMirrorViewBlitDescDelegate>("UnityEngine.XR.XRDisplaySubsystem::GetMirrorViewBlitDesc");
			XRDisplaySubsystem.AddGraphicsThreadMirrorViewBlitDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.AddGraphicsThreadMirrorViewBlitDelegate>("UnityEngine.XR.XRDisplaySubsystem::AddGraphicsThreadMirrorViewBlit");
			XRDisplaySubsystem.SetFocusPlane_InjectedDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystem.SetFocusPlane_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::SetFocusPlane_Injected");
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00004AFC File Offset: 0x00002CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158316, XrefRangeEnd = 158319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeDisplayFocusChanged(bool focus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref focus;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.NativeMethodInfoPtr_InvokeDisplayFocusChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00004B3C File Offset: 0x00002D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158319, XrefRangeEnd = 158322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XRDisplaySubsystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000026C6 File Offset: 0x000008C6
		public XRDisplaySubsystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00004B78 File Offset: 0x00002D78
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x000026CF File Offset: 0x000008CF
		public unsafe Action<bool> displayFocusChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.NativeFieldInfoPtr_displayFocusChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRDisplaySubsystem.NativeFieldInfoPtr_displayFocusChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000026EE File Offset: 0x000008EE
		public void add_displayFocusChanged(Action<bool> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000026FB File Offset: 0x000008FB
		public void remove_displayFocusChanged(Action<bool> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00004BA8 File Offset: 0x00002DA8
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x00004BC8 File Offset: 0x00002DC8
		public bool singlePassRenderingDisabled
		{
			get
			{
				return (this.textureLayout & XRDisplaySubsystem.TextureLayout.Texture2DArray) == (XRDisplaySubsystem.TextureLayout)0;
			}
			set
			{
				if (value)
				{
					this.textureLayout = XRDisplaySubsystem.TextureLayout.SeparateTexture2Ds;
				}
				else
				{
					bool flag = (this.supportedTextureLayouts & XRDisplaySubsystem.TextureLayout.Texture2DArray) > (XRDisplaySubsystem.TextureLayout)0;
					if (flag)
					{
						this.textureLayout = XRDisplaySubsystem.TextureLayout.Texture2DArray;
					}
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00002708 File Offset: 0x00000908
		public bool displayOpaque
		{
			get
			{
				return XRDisplaySubsystem.get_displayOpaqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000271A File Offset: 0x0000091A
		// (set) Token: 0x060000DA RID: 218 RVA: 0x0000272C File Offset: 0x0000092C
		public bool contentProtectionEnabled
		{
			get
			{
				return XRDisplaySubsystem.get_contentProtectionEnabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				XRDisplaySubsystem.set_contentProtectionEnabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0000273F File Offset: 0x0000093F
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00002751 File Offset: 0x00000951
		public float scaleOfAllViewports
		{
			get
			{
				return XRDisplaySubsystem.get_scaleOfAllViewportsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				XRDisplaySubsystem.set_scaleOfAllViewportsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00002764 File Offset: 0x00000964
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00002776 File Offset: 0x00000976
		public float scaleOfAllRenderTargets
		{
			get
			{
				return XRDisplaySubsystem.get_scaleOfAllRenderTargetsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				XRDisplaySubsystem.set_scaleOfAllRenderTargetsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00002789 File Offset: 0x00000989
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x0000279B File Offset: 0x0000099B
		public float zNear
		{
			get
			{
				return XRDisplaySubsystem.get_zNearDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				XRDisplaySubsystem.set_zNearDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x000027AE File Offset: 0x000009AE
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x000027C0 File Offset: 0x000009C0
		public float zFar
		{
			get
			{
				return XRDisplaySubsystem.get_zFarDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				XRDisplaySubsystem.set_zFarDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x000027D3 File Offset: 0x000009D3
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x000027E5 File Offset: 0x000009E5
		public bool sRGB
		{
			get
			{
				return XRDisplaySubsystem.get_sRGBDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				XRDisplaySubsystem.set_sRGBDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000027F8 File Offset: 0x000009F8
		public void MarkTransformLateLatched(Transform transform, XRDisplaySubsystem.LateLatchNode nodeType)
		{
			XRDisplaySubsystem.MarkTransformLateLatchedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(transform), nodeType);
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00002811 File Offset: 0x00000A11
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00002823 File Offset: 0x00000A23
		public XRDisplaySubsystem.TextureLayout textureLayout
		{
			get
			{
				return XRDisplaySubsystem.get_textureLayoutDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				XRDisplaySubsystem.set_textureLayoutDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00002836 File Offset: 0x00000A36
		public XRDisplaySubsystem.TextureLayout supportedTextureLayouts
		{
			get
			{
				return XRDisplaySubsystem.get_supportedTextureLayoutsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00002848 File Offset: 0x00000A48
		// (set) Token: 0x060000EA RID: 234 RVA: 0x0000285A File Offset: 0x00000A5A
		public XRDisplaySubsystem.ReprojectionMode reprojectionMode
		{
			get
			{
				return XRDisplaySubsystem.get_reprojectionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				XRDisplaySubsystem.set_reprojectionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000286D File Offset: 0x00000A6D
		public void SetFocusPlane(Vector3 point, Vector3 normal, Vector3 velocity)
		{
			this.SetFocusPlane_Injected(ref point, ref normal, ref velocity);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000287B File Offset: 0x00000A7B
		public void SetMSAALevel(int level)
		{
			XRDisplaySubsystem.SetMSAALevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), level);
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000288E File Offset: 0x00000A8E
		// (set) Token: 0x060000EE RID: 238 RVA: 0x000028A0 File Offset: 0x00000AA0
		public bool disableLegacyRenderer
		{
			get
			{
				return XRDisplaySubsystem.get_disableLegacyRendererDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				XRDisplaySubsystem.set_disableLegacyRendererDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000028B3 File Offset: 0x00000AB3
		public int GetRenderPassCount()
		{
			return XRDisplaySubsystem.GetRenderPassCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00004C00 File Offset: 0x00002E00
		public void GetRenderPass(int renderPassIndex, out XRDisplaySubsystem.XRRenderPass renderPass)
		{
			bool flag = !this.Internal_TryGetRenderPass(renderPassIndex, out renderPass);
			if (flag)
			{
				throw new IndexOutOfRangeException("renderPassIndex");
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000028C5 File Offset: 0x00000AC5
		public bool Internal_TryGetRenderPass(int renderPassIndex, out XRDisplaySubsystem.XRRenderPass renderPass)
		{
			return XRDisplaySubsystem.Internal_TryGetRenderPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), renderPassIndex, out renderPass);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000028D9 File Offset: 0x00000AD9
		public bool TryGetAppGPUTimeLastFrame(out float gpuTimeLastFrame)
		{
			return XRDisplaySubsystem.TryGetAppGPUTimeLastFrameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out gpuTimeLastFrame);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000028EC File Offset: 0x00000AEC
		public bool TryGetCompositorGPUTimeLastFrame(out float gpuTimeLastFrameCompositor)
		{
			return XRDisplaySubsystem.TryGetCompositorGPUTimeLastFrameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out gpuTimeLastFrameCompositor);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000028FF File Offset: 0x00000AFF
		public bool TryGetDroppedFrameCount(out int droppedFrameCount)
		{
			return XRDisplaySubsystem.TryGetDroppedFrameCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out droppedFrameCount);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002912 File Offset: 0x00000B12
		public bool TryGetFramePresentCount(out int framePresentCount)
		{
			return XRDisplaySubsystem.TryGetFramePresentCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out framePresentCount);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002925 File Offset: 0x00000B25
		public bool TryGetDisplayRefreshRate(out float displayRefreshRate)
		{
			return XRDisplaySubsystem.TryGetDisplayRefreshRateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out displayRefreshRate);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002938 File Offset: 0x00000B38
		public bool TryGetMotionToPhoton(out float motionToPhoton)
		{
			return XRDisplaySubsystem.TryGetMotionToPhotonDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out motionToPhoton);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00004C2C File Offset: 0x00002E2C
		public RenderTexture GetRenderTextureForRenderPass(int renderPass)
		{
			IntPtr intPtr = XRDisplaySubsystem.GetRenderTextureForRenderPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), renderPass);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000294B File Offset: 0x00000B4B
		public int GetPreferredMirrorBlitMode()
		{
			return XRDisplaySubsystem.GetPreferredMirrorBlitModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000295D File Offset: 0x00000B5D
		public void SetPreferredMirrorBlitMode(int blitMode)
		{
			XRDisplaySubsystem.SetPreferredMirrorBlitModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), blitMode);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00004C5C File Offset: 0x00002E5C
		public bool GetMirrorViewBlitDesc(RenderTexture mirrorRt, out XRDisplaySubsystem.XRMirrorViewBlitDesc outDesc)
		{
			return this.GetMirrorViewBlitDesc(mirrorRt, out outDesc, -1);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002970 File Offset: 0x00000B70
		public bool GetMirrorViewBlitDesc(RenderTexture mirrorRt, out XRDisplaySubsystem.XRMirrorViewBlitDesc outDesc, int mode)
		{
			return XRDisplaySubsystem.GetMirrorViewBlitDescDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mirrorRt), out outDesc, mode);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00004C78 File Offset: 0x00002E78
		public bool AddGraphicsThreadMirrorViewBlit(CommandBuffer cmd, bool allowGraphicsStateInvalidate)
		{
			return this.AddGraphicsThreadMirrorViewBlit(cmd, allowGraphicsStateInvalidate, -1);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000298A File Offset: 0x00000B8A
		public bool AddGraphicsThreadMirrorViewBlit(CommandBuffer cmd, bool allowGraphicsStateInvalidate, int mode)
		{
			return XRDisplaySubsystem.AddGraphicsThreadMirrorViewBlitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(cmd), allowGraphicsStateInvalidate, mode);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000029A4 File Offset: 0x00000BA4
		public void SetFocusPlane_Injected(ref Vector3 point, ref Vector3 normal, ref Vector3 velocity)
		{
			XRDisplaySubsystem.SetFocusPlane_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref point, ref normal, ref velocity);
		}

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_displayFocusChanged;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_InvokeDisplayFocusChanged_Private_Void_Boolean_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000A0 RID: 160
		private static readonly XRDisplaySubsystem.get_displayOpaqueDelegate get_displayOpaqueDelegateField;

		// Token: 0x040000A1 RID: 161
		private static readonly XRDisplaySubsystem.get_contentProtectionEnabledDelegate get_contentProtectionEnabledDelegateField;

		// Token: 0x040000A2 RID: 162
		private static readonly XRDisplaySubsystem.set_contentProtectionEnabledDelegate set_contentProtectionEnabledDelegateField;

		// Token: 0x040000A3 RID: 163
		private static readonly XRDisplaySubsystem.get_scaleOfAllViewportsDelegate get_scaleOfAllViewportsDelegateField;

		// Token: 0x040000A4 RID: 164
		private static readonly XRDisplaySubsystem.set_scaleOfAllViewportsDelegate set_scaleOfAllViewportsDelegateField;

		// Token: 0x040000A5 RID: 165
		private static readonly XRDisplaySubsystem.get_scaleOfAllRenderTargetsDelegate get_scaleOfAllRenderTargetsDelegateField;

		// Token: 0x040000A6 RID: 166
		private static readonly XRDisplaySubsystem.set_scaleOfAllRenderTargetsDelegate set_scaleOfAllRenderTargetsDelegateField;

		// Token: 0x040000A7 RID: 167
		private static readonly XRDisplaySubsystem.get_zNearDelegate get_zNearDelegateField;

		// Token: 0x040000A8 RID: 168
		private static readonly XRDisplaySubsystem.set_zNearDelegate set_zNearDelegateField;

		// Token: 0x040000A9 RID: 169
		private static readonly XRDisplaySubsystem.get_zFarDelegate get_zFarDelegateField;

		// Token: 0x040000AA RID: 170
		private static readonly XRDisplaySubsystem.set_zFarDelegate set_zFarDelegateField;

		// Token: 0x040000AB RID: 171
		private static readonly XRDisplaySubsystem.get_sRGBDelegate get_sRGBDelegateField;

		// Token: 0x040000AC RID: 172
		private static readonly XRDisplaySubsystem.set_sRGBDelegate set_sRGBDelegateField;

		// Token: 0x040000AD RID: 173
		private static readonly XRDisplaySubsystem.MarkTransformLateLatchedDelegate MarkTransformLateLatchedDelegateField;

		// Token: 0x040000AE RID: 174
		private static readonly XRDisplaySubsystem.get_textureLayoutDelegate get_textureLayoutDelegateField;

		// Token: 0x040000AF RID: 175
		private static readonly XRDisplaySubsystem.set_textureLayoutDelegate set_textureLayoutDelegateField;

		// Token: 0x040000B0 RID: 176
		private static readonly XRDisplaySubsystem.get_supportedTextureLayoutsDelegate get_supportedTextureLayoutsDelegateField;

		// Token: 0x040000B1 RID: 177
		private static readonly XRDisplaySubsystem.get_reprojectionModeDelegate get_reprojectionModeDelegateField;

		// Token: 0x040000B2 RID: 178
		private static readonly XRDisplaySubsystem.set_reprojectionModeDelegate set_reprojectionModeDelegateField;

		// Token: 0x040000B3 RID: 179
		private static readonly XRDisplaySubsystem.SetMSAALevelDelegate SetMSAALevelDelegateField;

		// Token: 0x040000B4 RID: 180
		private static readonly XRDisplaySubsystem.get_disableLegacyRendererDelegate get_disableLegacyRendererDelegateField;

		// Token: 0x040000B5 RID: 181
		private static readonly XRDisplaySubsystem.set_disableLegacyRendererDelegate set_disableLegacyRendererDelegateField;

		// Token: 0x040000B6 RID: 182
		private static readonly XRDisplaySubsystem.GetRenderPassCountDelegate GetRenderPassCountDelegateField;

		// Token: 0x040000B7 RID: 183
		private static readonly XRDisplaySubsystem.Internal_TryGetRenderPassDelegate Internal_TryGetRenderPassDelegateField;

		// Token: 0x040000B8 RID: 184
		private static readonly XRDisplaySubsystem.TryGetAppGPUTimeLastFrameDelegate TryGetAppGPUTimeLastFrameDelegateField;

		// Token: 0x040000B9 RID: 185
		private static readonly XRDisplaySubsystem.TryGetCompositorGPUTimeLastFrameDelegate TryGetCompositorGPUTimeLastFrameDelegateField;

		// Token: 0x040000BA RID: 186
		private static readonly XRDisplaySubsystem.TryGetDroppedFrameCountDelegate TryGetDroppedFrameCountDelegateField;

		// Token: 0x040000BB RID: 187
		private static readonly XRDisplaySubsystem.TryGetFramePresentCountDelegate TryGetFramePresentCountDelegateField;

		// Token: 0x040000BC RID: 188
		private static readonly XRDisplaySubsystem.TryGetDisplayRefreshRateDelegate TryGetDisplayRefreshRateDelegateField;

		// Token: 0x040000BD RID: 189
		private static readonly XRDisplaySubsystem.TryGetMotionToPhotonDelegate TryGetMotionToPhotonDelegateField;

		// Token: 0x040000BE RID: 190
		private static readonly XRDisplaySubsystem.GetRenderTextureForRenderPassDelegate GetRenderTextureForRenderPassDelegateField;

		// Token: 0x040000BF RID: 191
		private static readonly XRDisplaySubsystem.GetPreferredMirrorBlitModeDelegate GetPreferredMirrorBlitModeDelegateField;

		// Token: 0x040000C0 RID: 192
		private static readonly XRDisplaySubsystem.SetPreferredMirrorBlitModeDelegate SetPreferredMirrorBlitModeDelegateField;

		// Token: 0x040000C1 RID: 193
		private static readonly XRDisplaySubsystem.GetMirrorViewBlitDescDelegate GetMirrorViewBlitDescDelegateField;

		// Token: 0x040000C2 RID: 194
		private static readonly XRDisplaySubsystem.AddGraphicsThreadMirrorViewBlitDelegate AddGraphicsThreadMirrorViewBlitDelegateField;

		// Token: 0x040000C3 RID: 195
		private static readonly XRDisplaySubsystem.SetFocusPlane_InjectedDelegate SetFocusPlane_InjectedDelegateField;

		// Token: 0x02000054 RID: 84
		[StructLayout(2)]
		public struct XRRenderPass
		{
			// Token: 0x060001B2 RID: 434 RVA: 0x000058B4 File Offset: 0x00003AB4
			// Note: this type is marked as 'beforefieldinit'.
			static XRRenderPass()
			{
				Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderPass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, "XRRenderPass");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderPass>.NativeClassPtr);
				XRDisplaySubsystem.XRRenderPass.NativeFieldInfoPtr_displaySubsystemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderPass>.NativeClassPtr, "displaySubsystemInstance");
				XRDisplaySubsystem.XRRenderPass.NativeFieldInfoPtr_renderPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderPass>.NativeClassPtr, "renderPassIndex");
				XRDisplaySubsystem.XRRenderPass.NativeFieldInfoPtr_renderTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderPass>.NativeClassPtr, "renderTarget");
				XRDisplaySubsystem.XRRenderPass.NativeFieldInfoPtr_renderTargetDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderPass>.NativeClassPtr, "renderTargetDesc");
				XRDisplaySubsystem.XRRenderPass.NativeFieldInfoPtr_shouldFillOutDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderPass>.NativeClassPtr, "shouldFillOutDepth");
				XRDisplaySubsystem.XRRenderPass.NativeFieldInfoPtr_cullingPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderPass>.NativeClassPtr, "cullingPassIndex");
			}

			// Token: 0x060001B3 RID: 435 RVA: 0x00002D39 File Offset: 0x00000F39
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XRDisplaySubsystem.XRRenderPass>.NativeClassPtr, ref this));
			}

			// Token: 0x04000141 RID: 321
			private static readonly IntPtr NativeFieldInfoPtr_displaySubsystemInstance;

			// Token: 0x04000142 RID: 322
			private static readonly IntPtr NativeFieldInfoPtr_renderPassIndex;

			// Token: 0x04000143 RID: 323
			private static readonly IntPtr NativeFieldInfoPtr_renderTarget;

			// Token: 0x04000144 RID: 324
			private static readonly IntPtr NativeFieldInfoPtr_renderTargetDesc;

			// Token: 0x04000145 RID: 325
			private static readonly IntPtr NativeFieldInfoPtr_shouldFillOutDepth;

			// Token: 0x04000146 RID: 326
			private static readonly IntPtr NativeFieldInfoPtr_cullingPassIndex;

			// Token: 0x04000147 RID: 327
			[FieldOffset(0)]
			public IntPtr displaySubsystemInstance;

			// Token: 0x04000148 RID: 328
			[FieldOffset(8)]
			public int renderPassIndex;

			// Token: 0x04000149 RID: 329
			[FieldOffset(16)]
			public RenderTargetIdentifier renderTarget;

			// Token: 0x0400014A RID: 330
			[FieldOffset(56)]
			public RenderTextureDescriptor renderTargetDesc;

			// Token: 0x0400014B RID: 331
			[FieldOffset(108)]
			[MarshalAs(4)]
			public bool shouldFillOutDepth;

			// Token: 0x0400014C RID: 332
			[FieldOffset(112)]
			public int cullingPassIndex;
		}

		// Token: 0x02000055 RID: 85
		[StructLayout(2)]
		public struct XRMirrorViewBlitDesc
		{
			// Token: 0x060001B4 RID: 436 RVA: 0x00005958 File Offset: 0x00003B58
			// Note: this type is marked as 'beforefieldinit'.
			static XRMirrorViewBlitDesc()
			{
				Il2CppClassPointerStore<XRDisplaySubsystem.XRMirrorViewBlitDesc>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, "XRMirrorViewBlitDesc");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRDisplaySubsystem.XRMirrorViewBlitDesc>.NativeClassPtr);
				XRDisplaySubsystem.XRMirrorViewBlitDesc.NativeFieldInfoPtr_displaySubsystemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRMirrorViewBlitDesc>.NativeClassPtr, "displaySubsystemInstance");
				XRDisplaySubsystem.XRMirrorViewBlitDesc.NativeFieldInfoPtr_nativeBlitAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRMirrorViewBlitDesc>.NativeClassPtr, "nativeBlitAvailable");
				XRDisplaySubsystem.XRMirrorViewBlitDesc.NativeFieldInfoPtr_nativeBlitInvalidStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRMirrorViewBlitDesc>.NativeClassPtr, "nativeBlitInvalidStates");
				XRDisplaySubsystem.XRMirrorViewBlitDesc.NativeFieldInfoPtr_blitParamsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem.XRMirrorViewBlitDesc>.NativeClassPtr, "blitParamsCount");
			}

			// Token: 0x060001B5 RID: 437 RVA: 0x00002D4B File Offset: 0x00000F4B
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XRDisplaySubsystem.XRMirrorViewBlitDesc>.NativeClassPtr, ref this));
			}

			// Token: 0x0400014D RID: 333
			private static readonly IntPtr NativeFieldInfoPtr_displaySubsystemInstance;

			// Token: 0x0400014E RID: 334
			private static readonly IntPtr NativeFieldInfoPtr_nativeBlitAvailable;

			// Token: 0x0400014F RID: 335
			private static readonly IntPtr NativeFieldInfoPtr_nativeBlitInvalidStates;

			// Token: 0x04000150 RID: 336
			private static readonly IntPtr NativeFieldInfoPtr_blitParamsCount;

			// Token: 0x04000151 RID: 337
			[FieldOffset(0)]
			public IntPtr displaySubsystemInstance;

			// Token: 0x04000152 RID: 338
			[FieldOffset(8)]
			[MarshalAs(4)]
			public bool nativeBlitAvailable;

			// Token: 0x04000153 RID: 339
			[FieldOffset(9)]
			[MarshalAs(4)]
			public bool nativeBlitInvalidStates;

			// Token: 0x04000154 RID: 340
			[FieldOffset(12)]
			public int blitParamsCount;
		}

		// Token: 0x02000056 RID: 86
		public enum LateLatchNode
		{
			// Token: 0x04000156 RID: 342
			Head,
			// Token: 0x04000157 RID: 343
			LeftHand,
			// Token: 0x04000158 RID: 344
			RightHand
		}

		// Token: 0x02000057 RID: 87
		public enum TextureLayout
		{
			// Token: 0x0400015A RID: 346
			Texture2DArray = 1,
			// Token: 0x0400015B RID: 347
			SingleTexture2D,
			// Token: 0x0400015C RID: 348
			SeparateTexture2Ds = 4
		}

		// Token: 0x02000058 RID: 88
		public enum ReprojectionMode
		{
			// Token: 0x0400015E RID: 350
			Unspecified,
			// Token: 0x0400015F RID: 351
			PositionAndOrientation,
			// Token: 0x04000160 RID: 352
			OrientationOnly,
			// Token: 0x04000161 RID: 353
			None
		}

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x060001B7 RID: 439
		private delegate bool get_displayOpaqueDelegate(IntPtr @this);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x060001B9 RID: 441
		private delegate bool get_contentProtectionEnabledDelegate(IntPtr @this);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x060001BB RID: 443
		private delegate void set_contentProtectionEnabledDelegate(IntPtr @this, bool value);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x060001BD RID: 445
		private delegate float get_scaleOfAllViewportsDelegate(IntPtr @this);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x060001BF RID: 447
		private delegate void set_scaleOfAllViewportsDelegate(IntPtr @this, float value);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x060001C1 RID: 449
		private delegate float get_scaleOfAllRenderTargetsDelegate(IntPtr @this);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x060001C3 RID: 451
		private delegate void set_scaleOfAllRenderTargetsDelegate(IntPtr @this, float value);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x060001C5 RID: 453
		private delegate float get_zNearDelegate(IntPtr @this);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x060001C7 RID: 455
		private delegate void set_zNearDelegate(IntPtr @this, float value);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x060001C9 RID: 457
		private delegate float get_zFarDelegate(IntPtr @this);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x060001CB RID: 459
		private delegate void set_zFarDelegate(IntPtr @this, float value);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x060001CD RID: 461
		private delegate bool get_sRGBDelegate(IntPtr @this);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x060001CF RID: 463
		private delegate void set_sRGBDelegate(IntPtr @this, bool value);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x060001D1 RID: 465
		private delegate void MarkTransformLateLatchedDelegate(IntPtr @this, IntPtr transform, XRDisplaySubsystem.LateLatchNode nodeType);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x060001D3 RID: 467
		private delegate XRDisplaySubsystem.TextureLayout get_textureLayoutDelegate(IntPtr @this);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x060001D5 RID: 469
		private delegate void set_textureLayoutDelegate(IntPtr @this, XRDisplaySubsystem.TextureLayout value);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x060001D7 RID: 471
		private delegate XRDisplaySubsystem.TextureLayout get_supportedTextureLayoutsDelegate(IntPtr @this);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x060001D9 RID: 473
		private delegate XRDisplaySubsystem.ReprojectionMode get_reprojectionModeDelegate(IntPtr @this);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x060001DB RID: 475
		private delegate void set_reprojectionModeDelegate(IntPtr @this, XRDisplaySubsystem.ReprojectionMode value);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x060001DD RID: 477
		private delegate void SetMSAALevelDelegate(IntPtr @this, int level);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x060001DF RID: 479
		private delegate bool get_disableLegacyRendererDelegate(IntPtr @this);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x060001E1 RID: 481
		private delegate void set_disableLegacyRendererDelegate(IntPtr @this, bool value);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x060001E3 RID: 483
		private delegate int GetRenderPassCountDelegate(IntPtr @this);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x060001E5 RID: 485
		private delegate bool Internal_TryGetRenderPassDelegate(IntPtr @this, int renderPassIndex, [Out] IntPtr renderPass);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x060001E7 RID: 487
		private delegate bool TryGetAppGPUTimeLastFrameDelegate(IntPtr @this, [Out] IntPtr gpuTimeLastFrame);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x060001E9 RID: 489
		private delegate bool TryGetCompositorGPUTimeLastFrameDelegate(IntPtr @this, [Out] IntPtr gpuTimeLastFrameCompositor);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x060001EB RID: 491
		private delegate bool TryGetDroppedFrameCountDelegate(IntPtr @this, [Out] IntPtr droppedFrameCount);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x060001ED RID: 493
		private delegate bool TryGetFramePresentCountDelegate(IntPtr @this, [Out] IntPtr framePresentCount);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x060001EF RID: 495
		private delegate bool TryGetDisplayRefreshRateDelegate(IntPtr @this, [Out] IntPtr displayRefreshRate);

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x060001F1 RID: 497
		private delegate bool TryGetMotionToPhotonDelegate(IntPtr @this, [Out] IntPtr motionToPhoton);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x060001F3 RID: 499
		private delegate IntPtr GetRenderTextureForRenderPassDelegate(IntPtr @this, int renderPass);

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x060001F5 RID: 501
		private delegate int GetPreferredMirrorBlitModeDelegate(IntPtr @this);

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x060001F7 RID: 503
		private delegate void SetPreferredMirrorBlitModeDelegate(IntPtr @this, int blitMode);

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x060001F9 RID: 505
		private delegate bool GetMirrorViewBlitDescDelegate(IntPtr @this, IntPtr mirrorRt, [Out] IntPtr outDesc, int mode);

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x060001FB RID: 507
		private delegate bool AddGraphicsThreadMirrorViewBlitDelegate(IntPtr @this, IntPtr cmd, bool allowGraphicsStateInvalidate, int mode);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x060001FD RID: 509
		private delegate void SetFocusPlane_InjectedDelegate(IntPtr @this, IntPtr point, IntPtr normal, IntPtr velocity);
	}
}
