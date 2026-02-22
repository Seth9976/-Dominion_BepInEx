using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000128 RID: 296
	public class UIParticleSystem : MaskableGraphic
	{
		// Token: 0x06002122 RID: 8482 RVA: 0x0007EB80 File Offset: 0x0007CD80
		// Note: this type is marked as 'beforefieldinit'.
		static UIParticleSystem()
		{
			Il2CppClassPointerStore<UIParticleSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.UI.Extensions", "UIParticleSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIParticleSystem>.NativeClassPtr);
			UIParticleSystem.NativeFieldInfoPtr_particleTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIParticleSystem>.NativeClassPtr, "particleTexture");
			UIParticleSystem.NativeFieldInfoPtr_particleSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIParticleSystem>.NativeClassPtr, "particleSprite");
			UIParticleSystem.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIParticleSystem>.NativeClassPtr, "_transform");
			UIParticleSystem.NativeFieldInfoPtr__particleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIParticleSystem>.NativeClassPtr, "_particleSystem");
			UIParticleSystem.NativeFieldInfoPtr__particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIParticleSystem>.NativeClassPtr, "_particles");
			UIParticleSystem.NativeFieldInfoPtr__quad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIParticleSystem>.NativeClassPtr, "_quad");
			UIParticleSystem.NativeFieldInfoPtr__uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIParticleSystem>.NativeClassPtr, "_uv");
			UIParticleSystem.NativeFieldInfoPtr__textureSheetAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIParticleSystem>.NativeClassPtr, "_textureSheetAnimation");
			UIParticleSystem.NativeFieldInfoPtr__textureSheetAnimationFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIParticleSystem>.NativeClassPtr, "_textureSheetAnimationFrames");
			UIParticleSystem.NativeFieldInfoPtr__textureSheedAnimationFrameSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIParticleSystem>.NativeClassPtr, "_textureSheedAnimationFrameSize");
			UIParticleSystem.NativeMethodInfoPtr_get_mainTexture_Public_Virtual_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIParticleSystem>.NativeClassPtr, 100665997);
			UIParticleSystem.NativeMethodInfoPtr_Initialize_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIParticleSystem>.NativeClassPtr, 100665998);
			UIParticleSystem.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIParticleSystem>.NativeClassPtr, 100665999);
			UIParticleSystem.NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIParticleSystem>.NativeClassPtr, 100666000);
			UIParticleSystem.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIParticleSystem>.NativeClassPtr, 100666001);
			UIParticleSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIParticleSystem>.NativeClassPtr, 100666002);
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06002123 RID: 8483 RVA: 0x0007ECF0 File Offset: 0x0007CEF0
		public unsafe override Texture mainTexture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258200, XrefRangeEnd = 258207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIParticleSystem.NativeMethodInfoPtr_get_mainTexture_Public_Virtual_get_Texture_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x0007ED3C File Offset: 0x0007CF3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258261, RefRangeEnd = 258262, XrefRangeStart = 258207, XrefRangeEnd = 258261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIParticleSystem.NativeMethodInfoPtr_Initialize_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x0007ED78 File Offset: 0x0007CF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258262, XrefRangeEnd = 258265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIParticleSystem.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x0007EDB4 File Offset: 0x0007CFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258265, XrefRangeEnd = 258313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPopulateMesh(VertexHelper vh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIParticleSystem.NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x0007EE04 File Offset: 0x0007D004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258313, XrefRangeEnd = 258316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIParticleSystem.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x0007EE38 File Offset: 0x0007D038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258316, XrefRangeEnd = 258321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIParticleSystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIParticleSystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIParticleSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x0001484C File Offset: 0x00012A4C
		public UIParticleSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x0600212A RID: 8490 RVA: 0x0007EE74 File Offset: 0x0007D074
		// (set) Token: 0x0600212B RID: 8491 RVA: 0x00014855 File Offset: 0x00012A55
		public unsafe Texture particleTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIParticleSystem.NativeFieldInfoPtr_particleTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIParticleSystem.NativeFieldInfoPtr_particleTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x0600212C RID: 8492 RVA: 0x0007EEA4 File Offset: 0x0007D0A4
		// (set) Token: 0x0600212D RID: 8493 RVA: 0x00014874 File Offset: 0x00012A74
		public unsafe Sprite particleSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIParticleSystem.NativeFieldInfoPtr_particleSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIParticleSystem.NativeFieldInfoPtr_particleSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x0600212E RID: 8494 RVA: 0x0007EED4 File Offset: 0x0007D0D4
		// (set) Token: 0x0600212F RID: 8495 RVA: 0x00014893 File Offset: 0x00012A93
		public unsafe Transform _transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIParticleSystem.NativeFieldInfoPtr__transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIParticleSystem.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06002130 RID: 8496 RVA: 0x0007EF04 File Offset: 0x0007D104
		// (set) Token: 0x06002131 RID: 8497 RVA: 0x000148B2 File Offset: 0x00012AB2
		public unsafe ParticleSystem _particleSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIParticleSystem.NativeFieldInfoPtr__particleSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIParticleSystem.NativeFieldInfoPtr__particleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06002132 RID: 8498 RVA: 0x0007EF34 File Offset: 0x0007D134
		// (set) Token: 0x06002133 RID: 8499 RVA: 0x000148D1 File Offset: 0x00012AD1
		public unsafe Il2CppStructArray<ParticleSystem.Particle> _particles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIParticleSystem.NativeFieldInfoPtr__particles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ParticleSystem.Particle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIParticleSystem.NativeFieldInfoPtr__particles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06002134 RID: 8500 RVA: 0x0007EF64 File Offset: 0x0007D164
		// (set) Token: 0x06002135 RID: 8501 RVA: 0x000148F0 File Offset: 0x00012AF0
		public unsafe Il2CppStructArray<UIVertex> _quad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIParticleSystem.NativeFieldInfoPtr__quad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<UIVertex>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIParticleSystem.NativeFieldInfoPtr__quad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06002136 RID: 8502 RVA: 0x0007EF94 File Offset: 0x0007D194
		// (set) Token: 0x06002137 RID: 8503 RVA: 0x0001490F File Offset: 0x00012B0F
		public unsafe Vector4 _uv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIParticleSystem.NativeFieldInfoPtr__uv);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIParticleSystem.NativeFieldInfoPtr__uv)) = value;
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06002138 RID: 8504 RVA: 0x0007EFBC File Offset: 0x0007D1BC
		// (set) Token: 0x06002139 RID: 8505 RVA: 0x0001492A File Offset: 0x00012B2A
		public ParticleSystem.TextureSheetAnimationModule _textureSheetAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIParticleSystem.NativeFieldInfoPtr__textureSheetAnimation);
				return new ParticleSystem.TextureSheetAnimationModule(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIParticleSystem.NativeFieldInfoPtr__textureSheetAnimation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x0600213A RID: 8506 RVA: 0x0007EFEC File Offset: 0x0007D1EC
		// (set) Token: 0x0600213B RID: 8507 RVA: 0x00014958 File Offset: 0x00012B58
		public unsafe int _textureSheetAnimationFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIParticleSystem.NativeFieldInfoPtr__textureSheetAnimationFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIParticleSystem.NativeFieldInfoPtr__textureSheetAnimationFrames)) = value;
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x0600213C RID: 8508 RVA: 0x0007F014 File Offset: 0x0007D214
		// (set) Token: 0x0600213D RID: 8509 RVA: 0x00014973 File Offset: 0x00012B73
		public unsafe Vector2 _textureSheedAnimationFrameSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIParticleSystem.NativeFieldInfoPtr__textureSheedAnimationFrameSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIParticleSystem.NativeFieldInfoPtr__textureSheedAnimationFrameSize)) = value;
			}
		}

		// Token: 0x0400163C RID: 5692
		private static readonly IntPtr NativeFieldInfoPtr_particleTexture;

		// Token: 0x0400163D RID: 5693
		private static readonly IntPtr NativeFieldInfoPtr_particleSprite;

		// Token: 0x0400163E RID: 5694
		private static readonly IntPtr NativeFieldInfoPtr__transform;

		// Token: 0x0400163F RID: 5695
		private static readonly IntPtr NativeFieldInfoPtr__particleSystem;

		// Token: 0x04001640 RID: 5696
		private static readonly IntPtr NativeFieldInfoPtr__particles;

		// Token: 0x04001641 RID: 5697
		private static readonly IntPtr NativeFieldInfoPtr__quad;

		// Token: 0x04001642 RID: 5698
		private static readonly IntPtr NativeFieldInfoPtr__uv;

		// Token: 0x04001643 RID: 5699
		private static readonly IntPtr NativeFieldInfoPtr__textureSheetAnimation;

		// Token: 0x04001644 RID: 5700
		private static readonly IntPtr NativeFieldInfoPtr__textureSheetAnimationFrames;

		// Token: 0x04001645 RID: 5701
		private static readonly IntPtr NativeFieldInfoPtr__textureSheedAnimationFrameSize;

		// Token: 0x04001646 RID: 5702
		private static readonly IntPtr NativeMethodInfoPtr_get_mainTexture_Public_Virtual_get_Texture_0;

		// Token: 0x04001647 RID: 5703
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Boolean_0;

		// Token: 0x04001648 RID: 5704
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04001649 RID: 5705
		private static readonly IntPtr NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_Void_VertexHelper_0;

		// Token: 0x0400164A RID: 5706
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400164B RID: 5707
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
