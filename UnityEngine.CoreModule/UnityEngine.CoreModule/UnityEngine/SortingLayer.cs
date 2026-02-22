using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000033 RID: 51
	[StructLayout(2)]
	public struct SortingLayer
	{
		// Token: 0x06000153 RID: 339 RVA: 0x00019ED4 File Offset: 0x000180D4
		// Note: this type is marked as 'beforefieldinit'.
		static SortingLayer()
		{
			Il2CppClassPointerStore<SortingLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SortingLayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr);
			SortingLayer.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, "m_Id");
			SortingLayer.NativeMethodInfoPtr_GetLayerValueFromID_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, 100663355);
			SortingLayer.GetSortingLayerIDsInternalDelegateField = IL2CPP.ResolveICall<SortingLayer.GetSortingLayerIDsInternalDelegate>("UnityEngine.SortingLayer::GetSortingLayerIDsInternal");
			SortingLayer.GetLayerValueFromNameDelegateField = IL2CPP.ResolveICall<SortingLayer.GetLayerValueFromNameDelegate>("UnityEngine.SortingLayer::GetLayerValueFromName");
			SortingLayer.NameToIDDelegateField = IL2CPP.ResolveICall<SortingLayer.NameToIDDelegate>("UnityEngine.SortingLayer::NameToID");
			SortingLayer.IDToNameDelegateField = IL2CPP.ResolveICall<SortingLayer.IDToNameDelegate>("UnityEngine.SortingLayer::IDToName");
			SortingLayer.IsValidDelegateField = IL2CPP.ResolveICall<SortingLayer.IsValidDelegate>("UnityEngine.SortingLayer::IsValid");
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00019F78 File Offset: 0x00018178
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 59130, RefRangeEnd = 59132, XrefRangeStart = 59128, XrefRangeEnd = 59130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLayerValueFromID(int id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayer.NativeMethodInfoPtr_GetLayerValueFromID_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002EDB File Offset: 0x000010DB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, ref this));
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00019FB8 File Offset: 0x000181B8
		public int id
		{
			get
			{
				return this.m_Id;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00019FD0 File Offset: 0x000181D0
		public string name
		{
			get
			{
				return SortingLayer.IDToName(this.m_Id);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00019FF0 File Offset: 0x000181F0
		public int value
		{
			get
			{
				return SortingLayer.GetLayerValueFromID(this.m_Id);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00002EED File Offset: 0x000010ED
		public static Il2CppStructArray<SortingLayer> layers
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0001A010 File Offset: 0x00018210
		public static Il2CppStructArray<int> GetSortingLayerIDsInternal()
		{
			IntPtr intPtr = SortingLayer.GetSortingLayerIDsInternalDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002EFA File Offset: 0x000010FA
		public static int GetLayerValueFromName(string name)
		{
			return SortingLayer.GetLayerValueFromNameDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002F0C File Offset: 0x0000110C
		public static int NameToID(string name)
		{
			return SortingLayer.NameToIDDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0001A038 File Offset: 0x00018238
		public static string IDToName(int id)
		{
			IntPtr intPtr = SortingLayer.IDToNameDelegateField(id);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002F1E File Offset: 0x0000111E
		public static bool IsValid(int id)
		{
			return SortingLayer.IsValidDelegateField(id);
		}

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_m_Id;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_GetLayerValueFromID_Public_Static_Int32_Int32_0;

		// Token: 0x040000FB RID: 251
		[FieldOffset(0)]
		public int m_Id;

		// Token: 0x040000FC RID: 252
		private static readonly SortingLayer.GetSortingLayerIDsInternalDelegate GetSortingLayerIDsInternalDelegateField;

		// Token: 0x040000FD RID: 253
		private static readonly SortingLayer.GetLayerValueFromNameDelegate GetLayerValueFromNameDelegateField;

		// Token: 0x040000FE RID: 254
		private static readonly SortingLayer.NameToIDDelegate NameToIDDelegateField;

		// Token: 0x040000FF RID: 255
		private static readonly SortingLayer.IDToNameDelegate IDToNameDelegateField;

		// Token: 0x04000100 RID: 256
		private static readonly SortingLayer.IsValidDelegate IsValidDelegateField;

		// Token: 0x02000312 RID: 786
		// (Invoke) Token: 0x060023E0 RID: 9184
		private delegate IntPtr GetSortingLayerIDsInternalDelegate();

		// Token: 0x02000313 RID: 787
		// (Invoke) Token: 0x060023E2 RID: 9186
		private delegate int GetLayerValueFromNameDelegate(IntPtr name);

		// Token: 0x02000314 RID: 788
		// (Invoke) Token: 0x060023E4 RID: 9188
		private delegate int NameToIDDelegate(IntPtr name);

		// Token: 0x02000315 RID: 789
		// (Invoke) Token: 0x060023E6 RID: 9190
		private delegate IntPtr IDToNameDelegate(int id);

		// Token: 0x02000316 RID: 790
		// (Invoke) Token: 0x060023E8 RID: 9192
		private delegate bool IsValidDelegate(int id);
	}
}
