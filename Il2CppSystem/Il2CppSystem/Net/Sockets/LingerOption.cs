using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000122 RID: 290
	public class LingerOption : Object
	{
		// Token: 0x06001347 RID: 4935 RVA: 0x000587F8 File Offset: 0x000569F8
		// Note: this type is marked as 'beforefieldinit'.
		static LingerOption()
		{
			Il2CppClassPointerStore<LingerOption>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "LingerOption");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LingerOption>.NativeClassPtr);
			LingerOption.NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LingerOption>.NativeClassPtr, "enabled");
			LingerOption.NativeFieldInfoPtr_lingerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LingerOption>.NativeClassPtr, "lingerTime");
			LingerOption.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LingerOption>.NativeClassPtr, 100665992);
			LingerOption.NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LingerOption>.NativeClassPtr, 100665993);
			LingerOption.NativeMethodInfoPtr_set_LingerTime_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LingerOption>.NativeClassPtr, 100665994);
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x0005888C File Offset: 0x00056A8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 55674, RefRangeEnd = 55676, XrefRangeStart = 55673, XrefRangeEnd = 55674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LingerOption(bool enable, int seconds)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LingerOption>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LingerOption.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000640 RID: 1600
		// (set) Token: 0x06001349 RID: 4937 RVA: 0x000588E4 File Offset: 0x00056AE4
		public unsafe bool Enabled
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LingerOption.NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000641 RID: 1601
		// (set) Token: 0x0600134A RID: 4938 RVA: 0x00058924 File Offset: 0x00056B24
		public unsafe int LingerTime
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LingerOption.NativeMethodInfoPtr_set_LingerTime_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x00009E56 File Offset: 0x00008056
		public LingerOption(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x00058964 File Offset: 0x00056B64
		// (set) Token: 0x0600134D RID: 4941 RVA: 0x00009E5F File Offset: 0x0000805F
		public unsafe bool enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LingerOption.NativeFieldInfoPtr_enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LingerOption.NativeFieldInfoPtr_enabled)) = value;
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x0600134E RID: 4942 RVA: 0x0005898C File Offset: 0x00056B8C
		// (set) Token: 0x0600134F RID: 4943 RVA: 0x00009E7A File Offset: 0x0000807A
		public unsafe int lingerTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LingerOption.NativeFieldInfoPtr_lingerTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LingerOption.NativeFieldInfoPtr_lingerTime)) = value;
			}
		}

		// Token: 0x04000F0B RID: 3851
		private static readonly IntPtr NativeFieldInfoPtr_enabled;

		// Token: 0x04000F0C RID: 3852
		private static readonly IntPtr NativeFieldInfoPtr_lingerTime;

		// Token: 0x04000F0D RID: 3853
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0;

		// Token: 0x04000F0E RID: 3854
		private static readonly IntPtr NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0;

		// Token: 0x04000F0F RID: 3855
		private static readonly IntPtr NativeMethodInfoPtr_set_LingerTime_Public_set_Void_Int32_0;
	}
}
