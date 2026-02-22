using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000BB RID: 187
	public class RuntimeInitializeOnLoadMethodAttribute : UnityEngine.Scripting.PreserveAttribute
	{
		// Token: 0x060010E7 RID: 4327 RVA: 0x00045108 File Offset: 0x00043308
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeInitializeOnLoadMethodAttribute()
		{
			Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RuntimeInitializeOnLoadMethodAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr);
			RuntimeInitializeOnLoadMethodAttribute.NativeFieldInfoPtr_m_LoadType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr, "m_LoadType");
			RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr, 100664450);
			RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_RuntimeInitializeLoadType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr, 100664451);
			RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr_set_loadType_Private_set_Void_RuntimeInitializeLoadType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr, 100664452);
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x00045188 File Offset: 0x00043388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72357, XrefRangeEnd = 72358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeInitializeOnLoadMethodAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x000451C4 File Offset: 0x000433C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72358, XrefRangeEnd = 72359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType loadType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref loadType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_RuntimeInitializeLoadType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x060010EE RID: 4334 RVA: 0x00045274 File Offset: 0x00043474
		// (set) Token: 0x060010EA RID: 4330 RVA: 0x0004520C File Offset: 0x0004340C
		public unsafe RuntimeInitializeLoadType loadType
		{
			get
			{
				return this.m_LoadType;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 21534, RefRangeEnd = 21538, XrefRangeStart = 21534, XrefRangeEnd = 21538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr_set_loadType_Private_set_Void_RuntimeInitializeLoadType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x0000A45D File Offset: 0x0000865D
		public RuntimeInitializeOnLoadMethodAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x060010EC RID: 4332 RVA: 0x0004524C File Offset: 0x0004344C
		// (set) Token: 0x060010ED RID: 4333 RVA: 0x0000A466 File Offset: 0x00008666
		public unsafe RuntimeInitializeLoadType m_LoadType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeInitializeOnLoadMethodAttribute.NativeFieldInfoPtr_m_LoadType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeInitializeOnLoadMethodAttribute.NativeFieldInfoPtr_m_LoadType)) = value;
			}
		}

		// Token: 0x04000CC4 RID: 3268
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadType;

		// Token: 0x04000CC5 RID: 3269
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000CC6 RID: 3270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RuntimeInitializeLoadType_0;

		// Token: 0x04000CC7 RID: 3271
		private static readonly IntPtr NativeMethodInfoPtr_set_loadType_Private_set_Void_RuntimeInitializeLoadType_0;
	}
}
