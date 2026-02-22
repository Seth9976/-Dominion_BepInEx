using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono
{
	// Token: 0x0200000D RID: 13
	public static class RuntimeStructs : Object
	{
		// Token: 0x06000045 RID: 69 RVA: 0x000020F7 File Offset: 0x000002F7
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeStructs()
		{
			Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "RuntimeStructs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000211C File Offset: 0x0000031C
		public RuntimeStructs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0200052F RID: 1327
		[StructLayout(2)]
		public struct RemoteClass
		{
			// Token: 0x06004D5A RID: 19802 RVA: 0x0015D3C8 File Offset: 0x0015B5C8
			// Note: this type is marked as 'beforefieldinit'.
			static RemoteClass()
			{
				Il2CppClassPointerStore<RuntimeStructs.RemoteClass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr, "RemoteClass");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeStructs.RemoteClass>.NativeClassPtr);
				RuntimeStructs.RemoteClass.NativeFieldInfoPtr_default_vtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.RemoteClass>.NativeClassPtr, "default_vtable");
				RuntimeStructs.RemoteClass.NativeFieldInfoPtr_xdomain_vtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.RemoteClass>.NativeClassPtr, "xdomain_vtable");
				RuntimeStructs.RemoteClass.NativeFieldInfoPtr_proxy_class = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.RemoteClass>.NativeClassPtr, "proxy_class");
				RuntimeStructs.RemoteClass.NativeFieldInfoPtr_proxy_class_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.RemoteClass>.NativeClassPtr, "proxy_class_name");
				RuntimeStructs.RemoteClass.NativeFieldInfoPtr_interface_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.RemoteClass>.NativeClassPtr, "interface_count");
			}

			// Token: 0x06004D5B RID: 19803 RVA: 0x0001D42A File Offset: 0x0001B62A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeStructs.RemoteClass>.NativeClassPtr, ref this));
			}

			// Token: 0x04003E36 RID: 15926
			private static readonly IntPtr NativeFieldInfoPtr_default_vtable;

			// Token: 0x04003E37 RID: 15927
			private static readonly IntPtr NativeFieldInfoPtr_xdomain_vtable;

			// Token: 0x04003E38 RID: 15928
			private static readonly IntPtr NativeFieldInfoPtr_proxy_class;

			// Token: 0x04003E39 RID: 15929
			private static readonly IntPtr NativeFieldInfoPtr_proxy_class_name;

			// Token: 0x04003E3A RID: 15930
			private static readonly IntPtr NativeFieldInfoPtr_interface_count;

			// Token: 0x04003E3B RID: 15931
			[FieldOffset(0)]
			public IntPtr default_vtable;

			// Token: 0x04003E3C RID: 15932
			[FieldOffset(8)]
			public IntPtr xdomain_vtable;

			// Token: 0x04003E3D RID: 15933
			[FieldOffset(16)]
			public IntPtr proxy_class;

			// Token: 0x04003E3E RID: 15934
			[FieldOffset(24)]
			public IntPtr proxy_class_name;

			// Token: 0x04003E3F RID: 15935
			[FieldOffset(32)]
			public uint interface_count;
		}

		// Token: 0x02000530 RID: 1328
		[StructLayout(2)]
		public struct MonoClass
		{
			// Token: 0x06004D5C RID: 19804 RVA: 0x0001D43C File Offset: 0x0001B63C
			// Note: this type is marked as 'beforefieldinit'.
			static MonoClass()
			{
				Il2CppClassPointerStore<RuntimeStructs.MonoClass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr, "MonoClass");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeStructs.MonoClass>.NativeClassPtr);
			}

			// Token: 0x06004D5D RID: 19805 RVA: 0x0001D45C File Offset: 0x0001B65C
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeStructs.MonoClass>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000531 RID: 1329
		[StructLayout(2)]
		public struct GenericParamInfo
		{
			// Token: 0x06004D5E RID: 19806 RVA: 0x0015D458 File Offset: 0x0015B658
			// Note: this type is marked as 'beforefieldinit'.
			static GenericParamInfo()
			{
				Il2CppClassPointerStore<RuntimeStructs.GenericParamInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr, "GenericParamInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeStructs.GenericParamInfo>.NativeClassPtr);
				RuntimeStructs.GenericParamInfo.NativeFieldInfoPtr_pklass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.GenericParamInfo>.NativeClassPtr, "pklass");
				RuntimeStructs.GenericParamInfo.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.GenericParamInfo>.NativeClassPtr, "name");
				RuntimeStructs.GenericParamInfo.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.GenericParamInfo>.NativeClassPtr, "flags");
				RuntimeStructs.GenericParamInfo.NativeFieldInfoPtr_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.GenericParamInfo>.NativeClassPtr, "token");
				RuntimeStructs.GenericParamInfo.NativeFieldInfoPtr_constraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.GenericParamInfo>.NativeClassPtr, "constraints");
			}

			// Token: 0x06004D5F RID: 19807 RVA: 0x0001D46E File Offset: 0x0001B66E
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeStructs.GenericParamInfo>.NativeClassPtr, ref this));
			}

			// Token: 0x04003E40 RID: 15936
			private static readonly IntPtr NativeFieldInfoPtr_pklass;

			// Token: 0x04003E41 RID: 15937
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04003E42 RID: 15938
			private static readonly IntPtr NativeFieldInfoPtr_flags;

			// Token: 0x04003E43 RID: 15939
			private static readonly IntPtr NativeFieldInfoPtr_token;

			// Token: 0x04003E44 RID: 15940
			private static readonly IntPtr NativeFieldInfoPtr_constraints;

			// Token: 0x04003E45 RID: 15941
			[FieldOffset(0)]
			public IntPtr pklass;

			// Token: 0x04003E46 RID: 15942
			[FieldOffset(8)]
			public IntPtr name;

			// Token: 0x04003E47 RID: 15943
			[FieldOffset(16)]
			public ushort flags;

			// Token: 0x04003E48 RID: 15944
			[FieldOffset(20)]
			public uint token;

			// Token: 0x04003E49 RID: 15945
			[FieldOffset(24)]
			public IntPtr constraints;
		}

		// Token: 0x02000532 RID: 1330
		[StructLayout(2)]
		public struct GPtrArray
		{
			// Token: 0x06004D60 RID: 19808 RVA: 0x0015D4E8 File Offset: 0x0015B6E8
			// Note: this type is marked as 'beforefieldinit'.
			static GPtrArray()
			{
				Il2CppClassPointerStore<RuntimeStructs.GPtrArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr, "GPtrArray");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeStructs.GPtrArray>.NativeClassPtr);
				RuntimeStructs.GPtrArray.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.GPtrArray>.NativeClassPtr, "data");
				RuntimeStructs.GPtrArray.NativeFieldInfoPtr_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.GPtrArray>.NativeClassPtr, "len");
			}

			// Token: 0x06004D61 RID: 19809 RVA: 0x0001D480 File Offset: 0x0001B680
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeStructs.GPtrArray>.NativeClassPtr, ref this));
			}

			// Token: 0x04003E4A RID: 15946
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04003E4B RID: 15947
			private static readonly IntPtr NativeFieldInfoPtr_len;

			// Token: 0x04003E4C RID: 15948
			[FieldOffset(0)]
			public IntPtr data;

			// Token: 0x04003E4D RID: 15949
			[FieldOffset(8)]
			public int len;
		}

		// Token: 0x02000533 RID: 1331
		[StructLayout(2)]
		public struct HandleStackMark
		{
			// Token: 0x06004D62 RID: 19810 RVA: 0x0015D53C File Offset: 0x0015B73C
			// Note: this type is marked as 'beforefieldinit'.
			static HandleStackMark()
			{
				Il2CppClassPointerStore<RuntimeStructs.HandleStackMark>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr, "HandleStackMark");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeStructs.HandleStackMark>.NativeClassPtr);
				RuntimeStructs.HandleStackMark.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.HandleStackMark>.NativeClassPtr, "size");
				RuntimeStructs.HandleStackMark.NativeFieldInfoPtr_interior_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.HandleStackMark>.NativeClassPtr, "interior_size");
				RuntimeStructs.HandleStackMark.NativeFieldInfoPtr_chunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.HandleStackMark>.NativeClassPtr, "chunk");
			}

			// Token: 0x06004D63 RID: 19811 RVA: 0x0001D492 File Offset: 0x0001B692
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeStructs.HandleStackMark>.NativeClassPtr, ref this));
			}

			// Token: 0x04003E4E RID: 15950
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x04003E4F RID: 15951
			private static readonly IntPtr NativeFieldInfoPtr_interior_size;

			// Token: 0x04003E50 RID: 15952
			private static readonly IntPtr NativeFieldInfoPtr_chunk;

			// Token: 0x04003E51 RID: 15953
			[FieldOffset(0)]
			public int size;

			// Token: 0x04003E52 RID: 15954
			[FieldOffset(4)]
			public int interior_size;

			// Token: 0x04003E53 RID: 15955
			[FieldOffset(8)]
			public IntPtr chunk;
		}

		// Token: 0x02000534 RID: 1332
		[StructLayout(2)]
		public struct MonoError
		{
			// Token: 0x06004D64 RID: 19812 RVA: 0x0015D5A4 File Offset: 0x0015B7A4
			// Note: this type is marked as 'beforefieldinit'.
			static MonoError()
			{
				Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr, "MonoError");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr);
				RuntimeStructs.MonoError.NativeFieldInfoPtr_error_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "error_code");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_0");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_1");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_2");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_3");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_4");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_5");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_6");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_7");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_8");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_11");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_12");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_13");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_14");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_15");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_16");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_17");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_18");
			}

			// Token: 0x06004D65 RID: 19813 RVA: 0x0001D4A4 File Offset: 0x0001B6A4
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, ref this));
			}

			// Token: 0x04003E54 RID: 15956
			private static readonly IntPtr NativeFieldInfoPtr_error_code;

			// Token: 0x04003E55 RID: 15957
			private static readonly IntPtr NativeFieldInfoPtr_hidden_0;

			// Token: 0x04003E56 RID: 15958
			private static readonly IntPtr NativeFieldInfoPtr_hidden_1;

			// Token: 0x04003E57 RID: 15959
			private static readonly IntPtr NativeFieldInfoPtr_hidden_2;

			// Token: 0x04003E58 RID: 15960
			private static readonly IntPtr NativeFieldInfoPtr_hidden_3;

			// Token: 0x04003E59 RID: 15961
			private static readonly IntPtr NativeFieldInfoPtr_hidden_4;

			// Token: 0x04003E5A RID: 15962
			private static readonly IntPtr NativeFieldInfoPtr_hidden_5;

			// Token: 0x04003E5B RID: 15963
			private static readonly IntPtr NativeFieldInfoPtr_hidden_6;

			// Token: 0x04003E5C RID: 15964
			private static readonly IntPtr NativeFieldInfoPtr_hidden_7;

			// Token: 0x04003E5D RID: 15965
			private static readonly IntPtr NativeFieldInfoPtr_hidden_8;

			// Token: 0x04003E5E RID: 15966
			private static readonly IntPtr NativeFieldInfoPtr_hidden_11;

			// Token: 0x04003E5F RID: 15967
			private static readonly IntPtr NativeFieldInfoPtr_hidden_12;

			// Token: 0x04003E60 RID: 15968
			private static readonly IntPtr NativeFieldInfoPtr_hidden_13;

			// Token: 0x04003E61 RID: 15969
			private static readonly IntPtr NativeFieldInfoPtr_hidden_14;

			// Token: 0x04003E62 RID: 15970
			private static readonly IntPtr NativeFieldInfoPtr_hidden_15;

			// Token: 0x04003E63 RID: 15971
			private static readonly IntPtr NativeFieldInfoPtr_hidden_16;

			// Token: 0x04003E64 RID: 15972
			private static readonly IntPtr NativeFieldInfoPtr_hidden_17;

			// Token: 0x04003E65 RID: 15973
			private static readonly IntPtr NativeFieldInfoPtr_hidden_18;

			// Token: 0x04003E66 RID: 15974
			[FieldOffset(0)]
			public ushort error_code;

			// Token: 0x04003E67 RID: 15975
			[FieldOffset(2)]
			public ushort hidden_0;

			// Token: 0x04003E68 RID: 15976
			[FieldOffset(8)]
			public IntPtr hidden_1;

			// Token: 0x04003E69 RID: 15977
			[FieldOffset(16)]
			public IntPtr hidden_2;

			// Token: 0x04003E6A RID: 15978
			[FieldOffset(24)]
			public IntPtr hidden_3;

			// Token: 0x04003E6B RID: 15979
			[FieldOffset(32)]
			public IntPtr hidden_4;

			// Token: 0x04003E6C RID: 15980
			[FieldOffset(40)]
			public IntPtr hidden_5;

			// Token: 0x04003E6D RID: 15981
			[FieldOffset(48)]
			public IntPtr hidden_6;

			// Token: 0x04003E6E RID: 15982
			[FieldOffset(56)]
			public IntPtr hidden_7;

			// Token: 0x04003E6F RID: 15983
			[FieldOffset(64)]
			public IntPtr hidden_8;

			// Token: 0x04003E70 RID: 15984
			[FieldOffset(72)]
			public IntPtr hidden_11;

			// Token: 0x04003E71 RID: 15985
			[FieldOffset(80)]
			public IntPtr hidden_12;

			// Token: 0x04003E72 RID: 15986
			[FieldOffset(88)]
			public IntPtr hidden_13;

			// Token: 0x04003E73 RID: 15987
			[FieldOffset(96)]
			public IntPtr hidden_14;

			// Token: 0x04003E74 RID: 15988
			[FieldOffset(104)]
			public IntPtr hidden_15;

			// Token: 0x04003E75 RID: 15989
			[FieldOffset(112)]
			public IntPtr hidden_16;

			// Token: 0x04003E76 RID: 15990
			[FieldOffset(120)]
			public IntPtr hidden_17;

			// Token: 0x04003E77 RID: 15991
			[FieldOffset(128)]
			public IntPtr hidden_18;
		}
	}
}
