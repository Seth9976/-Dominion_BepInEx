using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003E6 RID: 998
	public class CADArgHolder : Object
	{
		// Token: 0x06003F5C RID: 16220 RVA: 0x00126BB8 File Offset: 0x00124DB8
		// Note: this type is marked as 'beforefieldinit'.
		static CADArgHolder()
		{
			Il2CppClassPointerStore<CADArgHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CADArgHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CADArgHolder>.NativeClassPtr);
			CADArgHolder.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADArgHolder>.NativeClassPtr, "index");
			CADArgHolder.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADArgHolder>.NativeClassPtr, 100672567);
		}

		// Token: 0x06003F5D RID: 16221 RVA: 0x00126C10 File Offset: 0x00124E10
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CADArgHolder(int i)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CADArgHolder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADArgHolder.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F5E RID: 16222 RVA: 0x00017FC4 File Offset: 0x000161C4
		public CADArgHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x06003F5F RID: 16223 RVA: 0x00126C58 File Offset: 0x00124E58
		// (set) Token: 0x06003F60 RID: 16224 RVA: 0x00017FCD File Offset: 0x000161CD
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADArgHolder.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADArgHolder.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x0400340A RID: 13322
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x0400340B RID: 13323
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
	}
}
