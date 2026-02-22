using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000A0 RID: 160
	public sealed class RequireComponent : Attribute
	{
		// Token: 0x06000FCD RID: 4045 RVA: 0x000416A0 File Offset: 0x0003F8A0
		// Note: this type is marked as 'beforefieldinit'.
		static RequireComponent()
		{
			Il2CppClassPointerStore<RequireComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RequireComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr);
			RequireComponent.NativeFieldInfoPtr_m_Type0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr, "m_Type0");
			RequireComponent.NativeFieldInfoPtr_m_Type1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr, "m_Type1");
			RequireComponent.NativeFieldInfoPtr_m_Type2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr, "m_Type2");
			RequireComponent.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr, 100664322);
			RequireComponent.NativeMethodInfoPtr__ctor_Public_Void_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr, 100664323);
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00041734 File Offset: 0x0003F934
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequireComponent(Type requiredComponent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requiredComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequireComponent.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00041780 File Offset: 0x0003F980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequireComponent(Type requiredComponent, Type requiredComponent2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requiredComponent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requiredComponent2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequireComponent.NativeMethodInfoPtr__ctor_Public_Void_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00009D76 File Offset: 0x00007F76
		public RequireComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x000417E0 File Offset: 0x0003F9E0
		// (set) Token: 0x06000FD2 RID: 4050 RVA: 0x00009D7F File Offset: 0x00007F7F
		public unsafe Type m_Type0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequireComponent.NativeFieldInfoPtr_m_Type0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequireComponent.NativeFieldInfoPtr_m_Type0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x00041810 File Offset: 0x0003FA10
		// (set) Token: 0x06000FD4 RID: 4052 RVA: 0x00009D9E File Offset: 0x00007F9E
		public unsafe Type m_Type1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequireComponent.NativeFieldInfoPtr_m_Type1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequireComponent.NativeFieldInfoPtr_m_Type1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x00041840 File Offset: 0x0003FA40
		// (set) Token: 0x06000FD6 RID: 4054 RVA: 0x00009DBD File Offset: 0x00007FBD
		public unsafe Type m_Type2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequireComponent.NativeFieldInfoPtr_m_Type2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequireComponent.NativeFieldInfoPtr_m_Type2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C13 RID: 3091
		private static readonly IntPtr NativeFieldInfoPtr_m_Type0;

		// Token: 0x04000C14 RID: 3092
		private static readonly IntPtr NativeFieldInfoPtr_m_Type1;

		// Token: 0x04000C15 RID: 3093
		private static readonly IntPtr NativeFieldInfoPtr_m_Type2;

		// Token: 0x04000C16 RID: 3094
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Type_0;
	}
}
