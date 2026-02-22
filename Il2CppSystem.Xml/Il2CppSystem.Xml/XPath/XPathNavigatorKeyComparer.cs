using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.XPath
{
	// Token: 0x0200006D RID: 109
	public class XPathNavigatorKeyComparer : Object
	{
		// Token: 0x0600087D RID: 2173 RVA: 0x0002DD64 File Offset: 0x0002BF64
		// Note: this type is marked as 'beforefieldinit'.
		static XPathNavigatorKeyComparer()
		{
			Il2CppClassPointerStore<XPathNavigatorKeyComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.XPath", "XPathNavigatorKeyComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathNavigatorKeyComparer>.NativeClassPtr);
			XPathNavigatorKeyComparer.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigatorKeyComparer>.NativeClassPtr, 100664691);
			XPathNavigatorKeyComparer.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigatorKeyComparer>.NativeClassPtr, 100664692);
			XPathNavigatorKeyComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigatorKeyComparer>.NativeClassPtr, 100664693);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0002DDD0 File Offset: 0x0002BFD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21335, XrefRangeEnd = 21340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_IEqualityComparer_Equals(Object obj1, Object obj2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNavigatorKeyComparer.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0002DE30 File Offset: 0x0002C030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21340, XrefRangeEnd = 21343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IEqualityComparer_GetHashCode(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNavigatorKeyComparer.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x0002DE80 File Offset: 0x0002C080
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XPathNavigatorKeyComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathNavigatorKeyComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNavigatorKeyComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00004AD8 File Offset: 0x00002CD8
		public XPathNavigatorKeyComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
