using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Permissions
{
	// Token: 0x020002C5 RID: 709
	[Serializable]
	public sealed class SecurityPermissionAttribute : CodeAccessSecurityAttribute
	{
		// Token: 0x06002F49 RID: 12105 RVA: 0x000EE240 File Offset: 0x000EC440
		// Note: this type is marked as 'beforefieldinit'.
		static SecurityPermissionAttribute()
		{
			Il2CppClassPointerStore<SecurityPermissionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Permissions", "SecurityPermissionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecurityPermissionAttribute>.NativeClassPtr);
			SecurityPermissionAttribute.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityPermissionAttribute>.NativeClassPtr, "m_Flags");
			SecurityPermissionAttribute.NativeMethodInfoPtr_set_SkipVerification_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityPermissionAttribute>.NativeClassPtr, 100670794);
		}

		// Token: 0x17000B3C RID: 2876
		// (set) Token: 0x06002F4A RID: 12106 RVA: 0x000EE298 File Offset: 0x000EC498
		public unsafe bool SkipVerification
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityPermissionAttribute.NativeMethodInfoPtr_set_SkipVerification_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x00010847 File Offset: 0x0000EA47
		public SecurityPermissionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06002F4C RID: 12108 RVA: 0x000EE2D8 File Offset: 0x000EC4D8
		// (set) Token: 0x06002F4D RID: 12109 RVA: 0x00010850 File Offset: 0x0000EA50
		public unsafe SecurityPermissionFlag m_Flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityPermissionAttribute.NativeFieldInfoPtr_m_Flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityPermissionAttribute.NativeFieldInfoPtr_m_Flags)) = value;
			}
		}

		// Token: 0x040028D7 RID: 10455
		private static readonly IntPtr NativeFieldInfoPtr_m_Flags;

		// Token: 0x040028D8 RID: 10456
		private static readonly IntPtr NativeMethodInfoPtr_set_SkipVerification_Public_set_Void_Boolean_0;
	}
}
