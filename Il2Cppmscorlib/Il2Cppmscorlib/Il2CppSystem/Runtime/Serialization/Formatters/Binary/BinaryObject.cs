using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000358 RID: 856
	public sealed class BinaryObject : Object
	{
		// Token: 0x0600369B RID: 13979 RVA: 0x00108EF8 File Offset: 0x001070F8
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryObject()
		{
			Il2CppClassPointerStore<BinaryObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr);
			BinaryObject.NativeFieldInfoPtr_objectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr, "objectId");
			BinaryObject.NativeFieldInfoPtr_mapId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr, "mapId");
			BinaryObject.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr, 100671690);
			BinaryObject.NativeMethodInfoPtr_Set_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr, 100671691);
			BinaryObject.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr, 100671692);
			BinaryObject.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr, 100671693);
			BinaryObject.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr, 100671694);
		}

		// Token: 0x0600369C RID: 13980 RVA: 0x00108FB4 File Offset: 0x001071B4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObject.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600369D RID: 13981 RVA: 0x00108FF0 File Offset: 0x001071F0
		[CallerCount(0)]
		public unsafe void Set(int objectId, int mapId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mapId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObject.NativeMethodInfoPtr_Set_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600369E RID: 13982 RVA: 0x0010903C File Offset: 0x0010723C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344979, XrefRangeEnd = 344983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObject.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x00109080 File Offset: 0x00107280
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 344976, RefRangeEnd = 344979, XrefRangeStart = 344976, XrefRangeEnd = 344979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObject.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x001090C4 File Offset: 0x001072C4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObject.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036A1 RID: 13985 RVA: 0x00013A78 File Offset: 0x00011C78
		public BinaryObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x060036A2 RID: 13986 RVA: 0x001090F8 File Offset: 0x001072F8
		// (set) Token: 0x060036A3 RID: 13987 RVA: 0x00013A81 File Offset: 0x00011C81
		public unsafe int objectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObject.NativeFieldInfoPtr_objectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObject.NativeFieldInfoPtr_objectId)) = value;
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x060036A4 RID: 13988 RVA: 0x00109120 File Offset: 0x00107320
		// (set) Token: 0x060036A5 RID: 13989 RVA: 0x00013A9C File Offset: 0x00011C9C
		public unsafe int mapId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObject.NativeFieldInfoPtr_mapId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObject.NativeFieldInfoPtr_mapId)) = value;
			}
		}

		// Token: 0x04002DFE RID: 11774
		private static readonly IntPtr NativeFieldInfoPtr_objectId;

		// Token: 0x04002DFF RID: 11775
		private static readonly IntPtr NativeFieldInfoPtr_mapId;

		// Token: 0x04002E00 RID: 11776
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002E01 RID: 11777
		private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_Int32_Int32_0;

		// Token: 0x04002E02 RID: 11778
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002E03 RID: 11779
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002E04 RID: 11780
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
