using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020000C7 RID: 199
	public class StyleVariableContext : Object
	{
		// Token: 0x06000B56 RID: 2902 RVA: 0x0002F59C File Offset: 0x0002D79C
		// Note: this type is marked as 'beforefieldinit'.
		static StyleVariableContext()
		{
			Il2CppClassPointerStore<StyleVariableContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleVariableContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleVariableContext>.NativeClassPtr);
			StyleVariableContext.NativeFieldInfoPtr_none = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableContext>.NativeClassPtr, "none");
			StyleVariableContext.NativeFieldInfoPtr_m_VariableHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableContext>.NativeClassPtr, "m_VariableHash");
			StyleVariableContext.NativeFieldInfoPtr_m_Variables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableContext>.NativeClassPtr, "m_Variables");
			StyleVariableContext.NativeFieldInfoPtr_m_SortedHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableContext>.NativeClassPtr, "m_SortedHash");
			StyleVariableContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariableContext>.NativeClassPtr, 100664263);
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0002F630 File Offset: 0x0002D830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97203, XrefRangeEnd = 97216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleVariableContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleVariableContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariableContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x000071C1 File Offset: 0x000053C1
		public StyleVariableContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x0002F66C File Offset: 0x0002D86C
		// (set) Token: 0x06000B5A RID: 2906 RVA: 0x000071CA File Offset: 0x000053CA
		public unsafe static StyleVariableContext none
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StyleVariableContext.NativeFieldInfoPtr_none, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleVariableContext>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StyleVariableContext.NativeFieldInfoPtr_none, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x0002F694 File Offset: 0x0002D894
		// (set) Token: 0x06000B5C RID: 2908 RVA: 0x000071DC File Offset: 0x000053DC
		public unsafe int m_VariableHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableContext.NativeFieldInfoPtr_m_VariableHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableContext.NativeFieldInfoPtr_m_VariableHash)) = value;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x0002F6BC File Offset: 0x0002D8BC
		// (set) Token: 0x06000B5E RID: 2910 RVA: 0x000071F7 File Offset: 0x000053F7
		public unsafe List<StyleVariable> m_Variables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableContext.NativeFieldInfoPtr_m_Variables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StyleVariable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableContext.NativeFieldInfoPtr_m_Variables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x0002F6EC File Offset: 0x0002D8EC
		// (set) Token: 0x06000B60 RID: 2912 RVA: 0x00007216 File Offset: 0x00005416
		public unsafe List<int> m_SortedHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableContext.NativeFieldInfoPtr_m_SortedHash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableContext.NativeFieldInfoPtr_m_SortedHash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x0002F71C File Offset: 0x0002D91C
		public void Add(StyleVariable sv)
		{
			int hashCode = sv.GetHashCode();
			int num = this.m_SortedHash.BinarySearch(hashCode);
			bool flag = num >= 0;
			if (!flag)
			{
				this.m_SortedHash.Insert(~num, hashCode);
				this.m_Variables.Add(sv);
				this.m_VariableHash = ((this.m_Variables.Count == 0) ? sv.GetHashCode() : ((this.m_VariableHash * 397) ^ sv.GetHashCode()));
			}
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x0002F7AC File Offset: 0x0002D9AC
		public void AddInitialRange(StyleVariableContext other)
		{
			bool flag = other.m_Variables.Count > 0;
			if (flag)
			{
				Debug.Assert(this.m_Variables.Count == 0);
				this.m_VariableHash = other.m_VariableHash;
				this.m_Variables.AddRange(other.m_Variables);
				this.m_SortedHash.AddRange(other.m_SortedHash);
			}
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0002F814 File Offset: 0x0002DA14
		public void Clear()
		{
			bool flag = this.m_Variables.Count > 0;
			if (flag)
			{
				this.m_Variables.Clear();
				this.m_VariableHash = 0;
				this.m_SortedHash.Clear();
			}
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0002F858 File Offset: 0x0002DA58
		public bool TryFindVariable(string name, out StyleVariable v)
		{
			for (int i = this.m_Variables.Count - 1; i >= 0; i--)
			{
				bool flag = this.m_Variables[i].name == name;
				if (flag)
				{
					v = this.m_Variables[i];
					return true;
				}
			}
			v = null;
			return false;
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x0002F8C8 File Offset: 0x0002DAC8
		public int GetVariableHash()
		{
			return this.m_VariableHash;
		}

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeFieldInfoPtr_none;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeFieldInfoPtr_m_VariableHash;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeFieldInfoPtr_m_Variables;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeFieldInfoPtr_m_SortedHash;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
